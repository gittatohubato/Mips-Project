Imports System.Threading
Imports System.IO

Public Class Form3

    Dim a As New Process

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_1.txt"       'address from user
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

        ''run assembler

        'a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\assembler.py"             'run assembler to get machine code file
        'a.Start()
        'Thread.Sleep(3000)
        'a.Close()

        ''///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ''openning modelsim (compile all + simulate + run)

        a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\GUI.bat"    'address of assembler txt file
        a.Start()
        Thread.Sleep(40000)

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_1.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button1.BackColor = Color.Red
                Exit Do

            End If
            Button1.BackColor = Color.Green
        Loop

        Reg_Mips.Close()

        'Button2.PerformClick()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_2.txt"        'address from user
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

        'a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\assembler.py"             'run assembler to get machine code file
        'a.Start()
        'Thread.Sleep(3000)
        'a.Close()

        ''///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ''openning modelsim (compile all + simulate + run)

        a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\GUI.bat"    'address of assembler txt file
        a.Start()
        Thread.Sleep(40000)

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_2.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button2.BackColor = Color.Red
                Exit Do

            End If
            Button2.BackColor = Color.Green
        Loop
        Reg_Mips.Close()
        'Button3.PerformClick()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_3.txt"      'address from user
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

        'a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\assembler.py"             'run assembler to get machine code file
        'a.Start()
        'Thread.Sleep(3000)
        'a.Close()

        ''///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ''openning modelsim (compile all + simulate + run)

        a.StartInfo.FileName = "C:\Modeltech_pe_edu_10.4a\examples\GUI.bat"    'address of assembler txt file
        a.Start()
        Thread.Sleep(30000)
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_3.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button3.BackColor = Color.Red
                Exit Do

            End If
            Button3.BackColor = Color.Green
        Loop

        Reg_Mips.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_4.txt"      'address from user
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

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_4.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button4.BackColor = Color.Red
                Exit Do

            End If
            Button4.BackColor = Color.Green
        Loop

        Button5.PerformClick()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_5.txt"      'address from user
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

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_5.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button5.BackColor = Color.Red
                Exit Do

            End If
            Button5.BackColor = Color.Green
        Loop

        Button6.PerformClick()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_6.txt"      'address from user
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

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_6.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button6.BackColor = Color.Red
                Exit Do

            End If
            Button6.BackColor = Color.Green
        Loop

        Button7.PerformClick()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_7.txt"        'address from user
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

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_7.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button7.BackColor = Color.Red
                Exit Do

            End If
            Button7.BackColor = Color.Green
        Loop

        Button8.PerformClick()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_8.txt"       'address from user
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

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_8.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button8.BackColor = Color.Red
                Exit Do

            End If
            Button8.BackColor = Color.Green
        Loop

        Button9.PerformClick()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_9.txt"        'address from user
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

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_9.txt.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button9.BackColor = Color.Red
                Exit Do

            End If
            Button9.BackColor = Color.Green
        Loop

        Button10.PerformClick()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        a.StartInfo.FileName = "C:\Users\Mohamed Amr\Downloads\test_case_10.txt"        'address from user
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

        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Dim regMips As String
        Dim testReg As String

        Dim Reg_Mips As System.IO.StreamReader
        Dim Test_Reg As System.IO.StreamReader

        Reg_Mips = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt")
        Test_Reg = File.OpenText("C:\Users\Mohamed Amr\Downloads\machine_code_10.txt")

        Do Until Reg_Mips.EndOfStream

            regMips = Reg_Mips.ReadLine & vbCrLf
            testReg = Test_Reg.ReadLine & vbCrLf

            If regMips = testReg Then

            Else Button10.BackColor = Color.Red
                Exit Do

            End If
            Button10.BackColor = Color.Green
        Loop

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()
    End Sub
End Class