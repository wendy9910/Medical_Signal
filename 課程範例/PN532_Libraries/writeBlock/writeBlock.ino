#include <SoftwareSerial.h>
#include <PN532_SWHSU.h>
#include <PN532.h>
SoftwareSerial SWSerial( 10, 11 ); // RX, TX
PN532_SWHSU pn532swhsu( SWSerial );
PN532 nfc( pn532swhsu );

boolean success;
uint8_t uid[] = { 0, 0, 0, 0, 0, 0, 0 };// Buffer to store the returned UID
uint8_t i,k,uidLength;//Length of the UID(4 or 7 bytes depending on ISO14443A card type)
uint8_t keyA[6] = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }; 
uint8_t iBlockNumber, keyType=0, assignBlockNum;
//keyType: Which key type to use during authentication (0 = MIFARE_CMD_AUTH_A, 1 = MIFARE_CMD_AUTH_B) 
uint8_t data[16]={15,14,13,12,11,10,9,8,7,6,5,4,3,2,1,0};
int iRes;
void setup(void) {
  Serial.begin(9600);
  //Serial.println("Hello Maker!");
  nfc.begin();
  uint32_t versiondata = nfc.getFirmwareVersion();
  if (! versiondata) {
    Serial.print("Didn't Find PN53x Module");
    while (1); // Halt
  }
  // Got valid data, print it out!
  Serial.print(F("Found chip PN5")); Serial.println((versiondata>>24) & 0xFF, HEX);
  Serial.print(F("Firmware ver. ")); Serial.print((versiondata>>16) & 0xFF, DEC);
  Serial.print('.'); Serial.println((versiondata>>8) & 0xFF, DEC);
  // Configure board to read RFID tags
  nfc.SAMConfig();
  Serial.println(F("Waiting for an ISO14443A Card ..."));
  k=255;
}

boolean getUID()
{
  boolean bRes = nfc.readPassiveTargetID(PN532_MIFARE_ISO14443A, uid, &uidLength);
  return bRes;
}

boolean readUID()
{
  boolean bRes = getUID();
  if (bRes)
  {
    if (uidLength == 4)
      Serial.println("Detected a Mifare Classic card (4 byte UID)"); 
    if (uidLength == 7)
      Serial.println("Detected a Mifare Ultralight tag (7 byte UID)"); 
    Serial.println("Found A ISO14443A Card!");
//    Serial.print("UID Length: ");
//    Serial.print(uidLength, DEC);
//    Serial.println(" bytes");
    Serial.print("UID Value: ");
    printHex(uid, uidLength);    
  }
  delay(1000);
  return bRes;  
}

int getBlock(uint8_t iBlckNum, uint8_t *buf)
{  
  boolean bOK;
  bOK = nfc.mifareclassic_AuthenticateBlock(uid, uidLength, iBlckNum, keyType, keyA);
  if (!bOK)
    return -1;
  //read block
  delay(1500);
  k=0;
  do{// Try to read the contents of block
    bOK = nfc.mifareclassic_ReadDataBlock(iBlckNum, buf);
    if (bOK)
      break;
    else
    {
      delay(1000);
      k++;
    }        
  }while( k< 10);
  if (bOK)
    return 0;
  else
    return -1;
}

int readBlock(uint8_t blckNum)
{
  int iRes=getBlock(blckNum, data);
  if (iRes != -1)
  {
    Serial.print(F("Block: "));
    Serial.print(iBlockNumber);
    Serial.println(F(" has been authenticated!"));
    if (iRes == 0)
    {
      Serial.print(F("Reading Block "));
      Serial.print(blckNum);
      Serial.println(":");
      printHex(data, 16); 
    }
    else
      Serial.println("Unable to read the requested block.  Try another key?\n\n");
  }
  else
    Serial.println("Authentication failed: Try another key?\n\n");  
  return iRes;
}
  
int writeBlock(uint8_t iBlckNum, uint8_t *buf)
{
  boolean bOK;
  bOK = nfc.mifareclassic_AuthenticateBlock(uid, uidLength, iBlckNum, keyType, keyA);
  if (!bOK)
    return -1;
  int iRes=nfc.mifareclassic_WriteDataBlock(iBlckNum,buf);  
  return iRes;
}

void loop() {
  success =readUID();
  if (success) {
    if (Serial.available() > 0)
    {
      //iBlockNumber=(uint8_t)Serial.read();
      iBlockNumber=Serial.parseInt();      
      iRes=readBlock(iBlockNumber);
      if (iRes == 0)
        k=0;      
    }
    if (k == 255)
    {
      Serial.print(F("Writing Block: "));
      iBlockNumber=4;
      Serial.println(iBlockNumber);
      iRes=writeBlock(iBlockNumber,data);
      if (iRes == 1)
      {
        Serial.println(F("Writing: OK!!"));
        k=254;
      }        
      else if (iRes == -1)
        Serial.println(F("Authentication: Fail!!"));
      else
        Serial.println(F("Writing: Fail!!"));
    }
  }
  else if (k==0)
  { // PN532 probably timed out waiting for a card
    Serial.println(F("Timed out! Waiting for a card..."));
    k++;
  }
  delay(1000);
}

//Helper routine to dump a byte array as hex values to Serial. 
void printHex(const uint8_t *buf,const byte bufferSize) {
  char res[bufferSize*3+1];
  for (byte i = 0; i < bufferSize; i++) {
    sprintf(res+i*3,"%02X ", *(buf+i));
  }
  Serial.println(res);
}
//Helper routine to dump a byte array as dec values to Serial.
void printDec(const uint8_t *buffer, const byte bufferSize) {
  byte i;
  for (i = 0; i < bufferSize-1; i++) {
    Serial.print(buffer[i]);
    Serial.print(", ");
  }
  Serial.println(buffer[i]);
}
void printASCII(const uint8_t *buffer, const byte bufferSize) {
  byte i;
  for (i = 0; i < bufferSize; i++) {
    Serial.write(buffer[i]);
  }
  Serial.println();
}
