Imports Microsoft.Win32

Public Class RegEdit
    Private regClasses = Registry.ClassesRoot
    Public Sub CreateRegistry()


        Dim checkReg = regClasses.OpenSubKey("*\shell\Check hash", True)
        If checkReg Is Nothing Then
            regClasses.CreateSubKey("*\shell\Check hash")
        End If
        Registry.SetValue("HKEY_CLASSES_ROOT\*\shell\Check hash", "SubCommands", "")
        'Registry.SetValue("HKEY_CLASSES_ROOT\*\shell\Check hash", "HasLUAShield", "")
        'create shell on parent
        regClasses.CreateSubKey("*\shell\Check hash\shell")
        'create MD5 key
        regClasses.CreateSubKey("*\shell\Check hash\shell\MD5")
        regClasses.CreateSubKey("*\shell\Check hash\shell\MD5\Command")
        Registry.SetValue("HKEY_CLASSES_ROOT\*\shell\Check hash\shell\MD5\Command", "", AppDomain.CurrentDomain.BaseDirectory & "ChecksumCheck.exe /md5 " & Chr(34) & "%1" & Chr(34))
        'create SHA1
        regClasses.CreateSubKey("*\shell\Check hash\shell\SHA-1")
        regClasses.CreateSubKey("*\shell\Check hash\shell\SHA-1\Command")
        Registry.SetValue("HKEY_CLASSES_ROOT\*\shell\Check hash\shell\SHA-1\Command", "", AppDomain.CurrentDomain.BaseDirectory & "ChecksumCheck.exe /sha1 " & Chr(34) & "%1" & Chr(34))
        'create SHA256
        regClasses.CreateSubKey("*\shell\Check hash\shell\SHA-256")
        regClasses.CreateSubKey("*\shell\Check hash\shell\SHA-256\Command")
        Registry.SetValue("HKEY_CLASSES_ROOT\*\shell\Check hash\shell\SHA-256\Command", "", AppDomain.CurrentDomain.BaseDirectory & "ChecksumCheck.exe /sha256 " & Chr(34) & "%1" & Chr(34))
        'create SHA512
        regClasses.CreateSubKey("*\shell\Check hash\shell\SHA-512")
        regClasses.CreateSubKey("*\shell\Check hash\shell\SHA-512\Command")
        Registry.SetValue("HKEY_CLASSES_ROOT\*\shell\Check hash\shell\SHA-512\Command", "", AppDomain.CurrentDomain.BaseDirectory & "ChecksumCheck.exe /sha512 " & Chr(34) & "%1" & Chr(34))
        'create CRC32  
        regClasses.CreateSubKey("*\shell\Check hash\shell\CRC32")
        regClasses.CreateSubKey("*\shell\Check hash\shell\CRC32\Command")
        Registry.SetValue("HKEY_CLASSES_ROOT\*\shell\Check hash\shell\CRC32\Command", "", AppDomain.CurrentDomain.BaseDirectory & "ChecksumCheck.exe /crc32 " & Chr(34) & "%1" & Chr(34))
    End Sub
    Public Sub DeleteRegistry()
        Dim RegClasses = Registry.ClassesRoot
        RegClasses.DeleteSubKeyTree("*\shell\Check hash")
    End Sub
    Public Function CheckIfRegistryExists() As Boolean
        Dim checkReg = regClasses.OpenSubKey("*\shell\Check hash", True)
        If checkReg Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
