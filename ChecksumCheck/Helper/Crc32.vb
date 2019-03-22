Option Infer On

' Copyright (c) Damien Guard.  All rights reserved.
' Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
' You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0

Imports System.Security.Cryptography

Namespace DamienG.Security.Cryptography

    ''' <summary>
    ''' Implements a 32-bit CRC hash algorithm compatible with Zip etc.
    ''' </summary>
    ''' <remarks>
    ''' Crc32 should only be used for backward compatibility with older file formats
    ''' and algorithms. It is not secure enough for new applications.
    ''' If you need to call multiple times for the same data either use the HashAlgorithm
    ''' interface or remember that the result of one Compute call needs to be ~ (XOR) before
    ''' being passed in as the seed for the next Compute call.
    ''' </remarks>
    Public NotInheritable Class Crc32
        Inherits HashAlgorithm

        Public Const DefaultPolynomial As UInt32 = &HEDB88320UI
        Public Const DefaultSeed As UInt32 = &HFFFFFFFFUI

        Private Shared defaultTable() As UInt32

        Private ReadOnly seed As UInt32
        Private ReadOnly table() As UInt32

        'INSTANT VB NOTE: The field hash was renamed since Visual Basic does not allow fields to have the same name as methods:
        Private hash_Renamed As UInt32

        Public Sub New()
            Me.New(DefaultPolynomial, DefaultSeed)
        End Sub

        Public Sub New(ByVal polynomial As UInt32, ByVal seed As UInt32)
            If Not BitConverter.IsLittleEndian Then
                Throw New PlatformNotSupportedException("Not supported on Big Endian processors")
            End If

            table = InitializeTable(polynomial)
            'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
            'ORIGINAL LINE: this.seed = hash = seed;
            hash_Renamed = seed
            Me.seed = hash_Renamed
        End Sub

        Public Overrides Sub Initialize()
            hash_Renamed = seed
        End Sub

        Protected Overrides Sub HashCore(ByVal array() As Byte, ByVal ibStart As Integer, ByVal cbSize As Integer)
            hash_Renamed = CalculateHash(table, hash_Renamed, array, ibStart, cbSize)
        End Sub

        Protected Overrides Function HashFinal() As Byte()
            Dim hashBuffer = UInt32ToBigEndianBytes(Not hash_Renamed)
            HashValue = hashBuffer
            Return hashBuffer
        End Function

        Public Overrides ReadOnly Property HashSize() As Integer
            Get
                Return 32
            End Get
        End Property

        Public Shared Function Compute(ByVal buffer() As Byte) As UInt32
            Return Compute(DefaultSeed, buffer)
        End Function

        Public Shared Function Compute(ByVal seed As UInt32, ByVal buffer() As Byte) As UInt32
            Return Compute(DefaultPolynomial, seed, buffer)
        End Function

        Public Shared Function Compute(ByVal polynomial As UInt32, ByVal seed As UInt32, ByVal buffer() As Byte) As UInt32
            Return Not CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length)
        End Function

        Private Shared Function InitializeTable(ByVal polynomial As UInt32) As UInt32()
            If polynomial = DefaultPolynomial AndAlso defaultTable IsNot Nothing Then
                Return defaultTable
            End If

            Dim createTable = New UInt32(255) {}
            For i = 0 To 255
                Dim entry = CUInt(i)
                For j = 0 To 7
                    If (entry And 1) = 1 Then
                        entry = (entry >> 1) Xor polynomial
                    Else
                        entry = entry >> 1
                    End If
                Next j
                createTable(i) = entry
            Next i

            If polynomial = DefaultPolynomial Then
                defaultTable = createTable
            End If

            Return createTable
        End Function

        Private Shared Function CalculateHash(ByVal table() As UInt32, ByVal seed As UInt32, ByVal buffer As IList(Of Byte), ByVal start As Integer, ByVal size As Integer) As UInt32
            'INSTANT VB NOTE: The variable hash was renamed since Visual Basic does not handle local variables named the same as class members well:
            Dim hash_Renamed = seed
            Dim i = start
            Do While i < start + size
                hash_Renamed = (hash_Renamed >> 8) Xor table(buffer(i) Xor hash_Renamed And &HFF)
                i += 1
            Loop
            Return hash_Renamed
        End Function

        Private Shared Function UInt32ToBigEndianBytes(ByVal uint32 As UInt32) As Byte()
            Dim result = BitConverter.GetBytes(uint32)

            If BitConverter.IsLittleEndian Then
                Array.Reverse(result)
            End If

            Return result
        End Function

    End Class

End Namespace