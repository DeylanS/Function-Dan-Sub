Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sub1()
        lblBaris1.Text = "Baris 1"
    End Sub

    Private Sub sub2(ByRef strText As String)
        strText = "Hello " + strText
    End Sub

    Private Function func1()
        Dim strText3 As String
        strText3 = "Baris 3"
        Return strText3
    End Function

    Private Function func2(ByVal strText2 As String) As String
        strText2 = txtBaris4.Text
        Return strText2
    End Function

    Private Sub btnBaris1_Click(sender As Object, e As EventArgs) Handles btnBaris1.Click
        sub1()
    End Sub

    Private Sub btnBaris2_Click(sender As Object, e As EventArgs) Handles btnBaris2.Click
        Dim strText As String = txtBaris2.Text
        sub2(strText)
        lblBaris2.Text = strText
    End Sub

    Private Sub btnBaris3_Click(sender As Object, e As EventArgs) Handles btnBaris3.Click
        lblBaris3.Text = func1()
    End Sub

    Private Sub btnBaris4_Click(sender As Object, e As EventArgs) Handles btnBaris4.Click
        lblBaris4.Text = func2(txtBaris4.Text)
    End Sub

    Private Sub lblBaris4_Click(sender As Object, e As EventArgs) Handles lblBaris4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub
End Class
