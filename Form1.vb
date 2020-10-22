Public Class Form1
    Dim str As String
    Dim ind As Integer
   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'color change
        ColorDialog1.ShowDialog()

        If RichTextBox1.SelectedText = "" Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        Else
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'font change
        FontDialog1.ShowDialog()
        If RichTextBox1.SelectedText = "" Then
            RichTextBox1.Font = FontDialog1.Font
        Else
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'open file
        dim bln as boolean
        OpenFileDialog1.InitialDirectory = "E:\\bca"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        bln=RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        if bln=true then messagebox.show("File have been successfully uploaded","Notepad")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'save file
            dim bln as boolean
        SaveFileDialog1.InitialDirectory = "E:\\bca"
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog1.ShowDialog()
        bln=RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            if bln=true then MessageBox.Show("File have been saved")
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        'clear
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

        'find
       
        str = InputBox("Enter the string you want to search.")
        ind = RichTextBox1.Find(str, RichTextBoxFinds.MatchCase)
        If ind = -1 Then
            MessageBox.Show("String not found")
        Else
            RichTextBox1.SelectionStart = ind
            RichTextBox1.SelectionLength = str.Length
            RichTextBox1.Focus()
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        'find next
        Dim nind As Integer
        If ind > -1 Then
            nind = RichTextBox1.Find(str, ind + str.Length, RichTextBoxFinds.MatchCase)
            If nind = -1 Then
                MessageBox.Show("no further string  found")
            Else
                RichTextBox1.SelectionStart = nind
                RichTextBox1.SelectionLength = str.Length
                RichTextBox1.Focus()
                ind = nind

            End If
        End If

        

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        'replace
        Dim rep As String

        str = InputBox("Enter the string you want to search.")
        rep = InputBox("Enter the string you want to replace with")
        ind = RichTextBox1.Find(str, RichTextBoxFinds.MatchCase)

        If ind = -1 Then
            MessageBox.Show("String not found")
        Else
            RichTextBox1.SelectionStart = ind
            RichTextBox1.SelectionLength = str.Length
            RichTextBox1.SelectedText = rep
            RichTextBox1.Focus()
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        End
    End Sub
End Class
