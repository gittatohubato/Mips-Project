Imports System.Threading
Imports System.IO

Public Class Form1

    Dim a As New Process
    Dim value As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'copy assembly code in given path to assembler file path

        'value = "E:\Mips Project\Data Memory & Register txt Files\hello.txt"

        a.StartInfo.FileName = value        'address from user
        a.Start()
        Thread.Sleep(1000)
        SendKeys.SendWait("^" + "{a}")
        SendKeys.SendWait("^" + "{c}")
        SendKeys.SendWait("%" + "{f4}")
        Thread.Sleep(100)
        a.Close()

        a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\assembly.txt"    'address of assembler txt file
        a.Start()
        Thread.Sleep(1000)
        SendKeys.SendWait("^" + "{a}")
        SendKeys.SendWait("^" + "{v}")
        SendKeys.SendWait("^" + "{s}")
        SendKeys.SendWait("%" + "{f4}")
        Thread.Sleep(100)
        a.Close()

        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        'run assembler

        a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\assembler.py"             'run assembler to get machine code file
        a.Start()
        Thread.Sleep(3000)
        a.Close()

        ''///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ''openning modelsim (compile all + simulate + run)

        a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\GUI.bat"    'address of assembler txt file
        a.Start()
        '///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Form2.Close()
        Form3.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        value = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Form2.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Form3.Close()

    End Sub
End Class
