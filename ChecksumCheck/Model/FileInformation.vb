Public Class FileInformation
    Private _FileName As String
    Private _Path As String
    Private _Format As String
    Private _MD5 As String
    Private _SHA1 As String
    Private _SHA256 As String
    Private _SHA512 As String
    Private _CRC32 As String
    Private _Index As Integer
    Public Property Index As Integer
        Get
            Return _Index
        End Get
        Set
            _Index = Value
        End Set
    End Property
    Public Property FileName As String
        Get
            Return _FileName
        End Get
        Set
            _FileName = Value
        End Set
    End Property

    Public Property Path As String
        Get
            Return _Path
        End Get
        Set
            _Path = Value
        End Set
    End Property

    Public Property Format As String
        Get
            Return _Format
        End Get
        Set
            _Format = Value
        End Set
    End Property

    Public Property MD5 As String
        Get
            Return _MD5
        End Get
        Set
            _MD5 = Value
        End Set
    End Property

    Public Property SHA1 As String
        Get
            Return _SHA1
        End Get
        Set
            _SHA1 = Value
        End Set
    End Property

    Public Property SHA256 As String
        Get
            Return _SHA256
        End Get
        Set
            _SHA256 = Value
        End Set
    End Property

    Public Property SHA512 As String
        Get
            Return _SHA512
        End Get
        Set
            _SHA512 = Value
        End Set
    End Property

    Public Property CRC32 As String
        Get
            Return _CRC32
        End Get
        Set
            _CRC32 = Value
        End Set
    End Property
End Class
