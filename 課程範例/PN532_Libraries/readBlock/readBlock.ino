#include <SoftwareSerial.h>
#include <PN532_SWHSU.h>
#include <PN532.h>
SoftwareSerial SWSerial( 10, 11 ); // RX, TX
PN532_SWHSU pn532swhsu( SWSerial );
PN532 nfc( pn532swhsu );

void setup(void) {
  Serial.begin(115200);
  Serial.println("Hello Maker!");
  nfc.begin();
  uint32_t versiondata = nfc.getFirmwareVersion();
  if (! versiondata) {
    Serial.print("Didn't Find PN53x Module");
    while (1); // Halt
  }
  // Got valid data, print it out!
  Serial.print("Found chip PN5"); Serial.println((versiondata>>24) & 0xFF, HEX);
  Serial.print("Firmware ver. "); Serial.print((versiondata>>16) & 0xFF, DEC);
  Serial.print('.'); Serial.println((versiondata>>8) & 0xFF, DEC);
  // Configure board to read RFID tags
  nfc.SAMConfig();
  Serial.println("Waiting for an ISO14443A Card ...");
}
boolean success;
uint8_t uid[] = { 0, 0, 0, 0, 0, 0, 0 };// Buffer to store the returned UID
uint8_t i,k,uidLength, iBlockNumber, keyNumber=0;//Length of the UID(4 or 7 bytes depending on ISO14443A card type)
uint8_t keyA[6] = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }; 
//keyNumber: Which key type to use during authentication (0 = MIFARE_CMD_AUTH_A, 1 = MIFARE_CMD_AUTH_B) 
uint8_t data[16];
void loop() {
  success = nfc.readPassiveTargetID(PN532_MIFARE_ISO14443A, uid, &uidLength);
  if (success) {// Display some basic information about the card 
    if (uidLength == 4)
      Serial.println("Seems to be a Mifare Classic card (4 byte UID)"); 
    Serial.println("Found A ISO14443A Card!");
    Serial.print("UID Length: ");
    Serial.print(uidLength, DEC);
    Serial.println(" bytes");
    Serial.print("UID Value: ");
    for (i=0; i < uidLength; i++)
    {
      Serial.print(" 0x");
      Serial.print(uid[i], HEX);
    }
    Serial.println();
    // Now we need to try to authenticate it for read/write access
    // Try with the factory default KeyA: 0xFF 0xFF 0xFF 0xFF 0xFF 0xFF
    Serial.println("Trying to authenticate block 4 with default KEYA value"); 
    // Start with block 4 (the first block of sector 1) 
    // since sector 0 contains the manufacturer data and it's probably better just
    // to leave it alone unless you know what you're doing     
    delay(1500);
    iBlockNumber=0;
    //uint8_t keyA[6] = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };     
    success = nfc.mifareclassic_AuthenticateBlock(uid, uidLength, iBlockNumber, keyNumber, keyA);     
    //success = nfc.mifareclassic_AuthenticateBlock(uid, uidLength, 4, 0, keyA);    
    if (success)
    {
        Serial.print(F("Block: "));
        Serial.print(iBlockNumber);
        Serial.println(F(" has been authenticated!"));                
        delay(1500);
        k=0;
        do{// Try to read the contents of block
          success = nfc.mifareclassic_ReadDataBlock(iBlockNumber, data);    
          //success = nfc.mifareclassic_ReadDataBlock(4, data);  
          if (success){// Data seems to have been read ... spit it out
            Serial.print(F("Reading Block "));
            Serial.print(iBlockNumber);
            Serial.println(":");
            nfc.PrintHexChar(data, 16);
            Serial.println();      
            k=0;
            break;
          }
          else
          {
            delay(1500);
            k++;
          }        
        }while( k< 10);
        if (!success)
          Serial.println("Ooops ... unable to read the requested block.  Try another key?\n\n");
    }
    else
      Serial.println("Ooops ... authentication failed: Try another key?\n\n");          
    delay(2000);
  }
  else if (k==0)
  { // PN532 probably timed out waiting for a card
    Serial.println("Timed out! Waiting for a card...");
    k++;
  }
}
