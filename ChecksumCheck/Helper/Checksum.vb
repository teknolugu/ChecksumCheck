Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports ChecksumCheck.DamienG.Security.Cryptography

Public Class Checksum

    Public Function ComputeFile(Path As String, Type As HashType) As String
        Dim buff As StringBuilder = New StringBuilder

        Select Case Type
            Case HashType.MD5
                Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
                Dim f As FileStream = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next
                f.Close()
            Case HashType.SHA1
                Dim md5 As SHA1CryptoServiceProvider = New SHA1CryptoServiceProvider
                Dim f As FileStream = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next
                f.Close()
            Case HashType.SHA256
                Dim md5 As SHA256CryptoServiceProvider = New SHA256CryptoServiceProvider
                Dim f As FileStream = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next
                f.Close()
            Case HashType.SHA512
                Dim md5 As SHA512CryptoServiceProvider = New SHA512CryptoServiceProvider
                Dim f As FileStream = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next
                f.Close()
            Case HashType.CRC32
                Dim crc32 As Crc32 = New Crc32
                Dim f As FileStream = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                crc32.ComputeHash(f)
                Dim hash As Byte() = crc32.Hash
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next
        End Select

        Return buff.ToString
    End Function

End Class