Public Class Form1
    Private Sub btnUcase_Click(sender As Object, e As EventArgs) Handles btnUcase.Click
        Dim LowerCase, UpperCase
        LowerCase = txtUcase.Text
        UpperCase = UCase(LowerCase)
        lbUcase.Text = UpperCase

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLen.Click
        Dim Cadena As String
        Dim Entero As Integer
        Cadena = txtLen.Text
        Entero = Len(Cadena)
        lbLen.Text = Entero
    End Sub

    Private Sub btnMid_Click(sender As Object, e As EventArgs) Handles btnMid.Click
        Dim CadenaMid As String
        Dim NewMid As String
        Dim EntLen As Integer
        Dim Uno As Integer
        Dim Dos As Integer
        CadenaMid = txtMid.Text
        EntLen = Len(CadenaMid)
        Uno = txtMid1.Text
        Dos = txtMid2.Text
        NewMid = Mid(CadenaMid, Uno, Dos)
        lbMid.Text = NewMid
    End Sub

    Private Sub txtMid_TextChanged(sender As Object, e As EventArgs) Handles txtMid.TextChanged

    End Sub
End Class
