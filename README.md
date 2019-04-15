![alt text](ChecksumCheck.png)

## What is ChecksumCheck
ChecksumCheck is software for checking file checksum. There are two types of ChecksumCheck applications including GUI-based and console-based.
The console-based app, we call it ChecksumCheck.Cmdl.

Some special features of ChecksumCheck :
* Multiple files check
* Drag and drop files
* Windows Explorer context menu integration
* Etc.

Supported Hash type :
* MD5
* SHA1
* SHA256
* SHA512
* CRC32

## ChecksumCheck.Cmdl usage
### **Installation** <br />
Rename the ChecksumCheck.Cmdl executable file to Checksum.exe <br />
Copy Checksum.exe file to the Windows System32 directory <br />
### **Command** <br />

`checksum "path to the file" -hashtype`
### For an example 
for checking MD5 checksum <br /> `checksum "C:\example\example.iso" -md5` <br />
### Another hashtype
Just change the **-md5** to type hash you want `-sha1`, `-sha256`, `-sha512`, or `-crc32`

## About
Made with ❤️ By Muhammad Arfan. from Jakarta, Indonesia <br />
Copyright © 2019 By Muhammad Arfan
