Public Class Form1
    Dim Angka1 As Integer
    Dim Angka2 As Integer
    Dim operasi As String
    Dim status As Boolean

    Private Sub input(ByVal angka As Char)
        If Me.status = True Then
            If (Me.TextBox1.Text = "0") Then
                Me.TextBox1.Text = Convert.ToString(angka)
            Else
                Dim TextBox1 As TextBox = Me.TextBox1
                TextBox1.Text = (TextBox1.Text & Convert.ToString(angka))
            End If
        Else
            Me.TextBox1.Text = Convert.ToString(angka)
            Me.status = True
        End If
    End Sub
    Private Sub inputOperator(ByVal oprator As String)
        If (Me.TextBox1.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.Angka1 = Convert.ToInt32(Me.TextBox1.Text)
                Me.TextBox1.Text = Me.Angka1.ToString
                Me.status = False
            Else
                Me.hitung()
            End If
            Me.operasi = oprator
        End If
    End Sub
    Private Sub hitung()
        Me.Angka2 = Convert.ToInt32(Me.TextBox1.Text)
        Select Case Me.operasi
            Case "+"
                Me.Angka1 = (Me.Angka1 + Me.Angka2)
                Exit Select
            Case "-"
                Me.Angka1 = (Me.Angka1 - Me.Angka2)
                Exit Select
        End Select
        Me.TextBox1.Text = Me.Angka1.ToString
        Me.status = False
    End Sub
    Private Sub btClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btClear.Click
        Me.TextBox1.Text = "0"
        Me.Angka1 = 0
        Me.operasi = String.Empty
    End Sub
    Private Sub btEquals_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEquals.Click
        If ((Me.TextBox1.Text <> "0") And (Me.Angka1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If
    End Sub
    Private Sub btTambah_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btTambah.Click
        Me.inputOperator("+")
    End Sub
    Private Sub btKurang_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btKurang.Click
        Me.inputOperator("-")
    End Sub
    Private Sub Button0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button0.Click
        If (Me.status AndAlso (Me.TextBox1.Text <> "0")) Then
            Dim resultText As TextBox = Me.TextBox1
            TextBox1.Text = (TextBox1.Text & "0")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.input("1")
    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.input("2")
    End Sub
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Me.input("3")
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Me.input("4")
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Me.input("5")
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        Me.input("6")
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        Me.input("7")
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        Me.input("8")
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
        Me.input("9")
    End Sub
End Class
