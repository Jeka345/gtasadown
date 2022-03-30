Imports System.Windows.Input
Public Class Class1
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Public Sub killed()
        Dim killed1 As Integer = GetAsyncKeyState(Key.LeftAlt)
        Dim killed2 As Integer = GetAsyncKeyState(Key.F3)
        If CBool(killed1 And killed2) Then
            Process.GetProcessesByName("gta_sa.exe")(0).Kill()
        End If
    End Sub
End Class
