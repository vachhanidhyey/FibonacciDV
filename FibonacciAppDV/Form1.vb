Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSequence.SelectedIndexChanged

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object,
 _
    ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim I, a, b, c As Integer, stri, StrC As String
        A = txtTerm1.Text
        b = txtTerm2.Text
        lstSequence.Items.Clear()
        For I = 3 To 10
            stri = CStr(I) ' make a string from the integer 
            stri = stri.PadLeft(3, " ")   ' totalof 3 characters
            c = a + b   ' calculate term from previous two
            StrC = CStrc(c)  ' make a string from the integer
            StrC = StrC.PadLeft(6, " ")   ' total of 6 characters
            lstSequence.Items.Add("Term" + stri + ":" + StrC)
            ' advance one term
            a = b
            b = c
        Next I
    End Sub

    Private Function CStrc(c As Integer) As String
        Throw New NotImplementedException
    End Function

    Private Sub txtTerm1_Leave(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles txtTerm1.Leave
        txtTerm1.Text = Val(txtTerm1)
    End Sub

    Private Sub txtTerm2_Leave(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles txtTerm2.Leave
        txtTerm2.Text = Val(txtTerm2)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles btnPrint.Click
        prtDoc.Print()   ' triggers prtDoc.PrintPage event
    End Sub
End Class
