Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Show Data Of Register & Memory On ListView

        'ListView Settings For Register

        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("REG_Address", 100)
        ListView1.Columns.Add("REG_Data", 200)

        'ListView Settings For Data Memory

        ListView2.View = View.Details
        ListView2.GridLines = True
        ListView2.FullRowSelect = True

        ListView2.Columns.Add("DataMemory_Address", 100)
        ListView2.Columns.Add("DataMemor_Data", 200)

        'ListView Settings For PC

        ListView3.View = View.Details
        ListView3.GridLines = True
        ListView3.FullRowSelect = True

        ListView3.Columns.Add("PC_DATA in Dceimal", 300)

        'DEFINING NECESSARY VARIABLES

        Dim arr(2) As String
        Dim counter As Int32

        Dim DataMemory_arr(2) As String
        Dim DataMemory_counter As Int32

        Dim PC_Line As String

        'MAKE LISTVIEW ITEMS

        Dim item As ListViewItem
        Dim DataMemory_item As ListViewItem
        Dim PC_item As ListViewItem

        'VARIABLES THAT OPEN FILE

        Dim Reg_Read As System.IO.StreamReader
        Dim DataMemory_Read As System.IO.StreamReader
        Dim PC_Read As System.IO.StreamReader


        'FILE PATHES

        Reg_Read = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\Register Output Data .txt") 'PATH OF REG TEXT FILE
        DataMemory_Read = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\DataMemory Output Data .txt") 'PATH OF DATA MEMORY TEXT FILE
        PC_Read = File.OpenText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\PC Output Data .txt") 'PATH OF REG TEXT FILE

        'INITIALIZING NECESSARY VARIABLES

        arr(0) = "0"
        counter = 0

        DataMemory_arr(0) = "0"
        DataMemory_counter = 0

        'Reading Line By Line From File And Save It In ListView FOR REGISTER FILE

        Do Until Reg_Read.EndOfStream

            counter = Convert.ToInt32(arr(0))
            arr(1) = Reg_Read.ReadLine & vbCrLf
            item = New ListViewItem(arr)
            ListView1.Items.Add(item)
            counter = counter + 1
            arr(0) = counter.ToString()
        Loop

        'Reading Line By Line From File And Save It In ListView FOR DATA MEMORY

        Do Until DataMemory_Read.EndOfStream

            DataMemory_counter = Convert.ToInt32(DataMemory_arr(0))
            DataMemory_arr(1) = DataMemory_Read.ReadLine & vbCrLf
            DataMemory_item = New ListViewItem(DataMemory_arr)
            ListView2.Items.Add(DataMemory_item)
            DataMemory_counter = DataMemory_counter + 1
            DataMemory_arr(0) = DataMemory_counter.ToString()
        Loop

        'Reading Line By Line From File And Save It In ListView FOR PC

        Do Until PC_Read.EndOfStream

            PC_Line = PC_Read.ReadLine & vbCrLf
            PC_item = New ListViewItem(PC_Line)
            ListView3.Items.Add(PC_item)
        Loop


        'close Reg_Read File

        Reg_Read.Close()

        'close DataMemory_Read File

        DataMemory_Read.Close()

        'close PC_Read File

        PC_Read.Close()
        System.IO.File.WriteAllText("C:\Modeltech_pe_edu_10.4a\examples\TEXT FILE OF OUTPUTS\PC Output Data .txt", "")

    End Sub

    Private Sub ListView3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub
End Class