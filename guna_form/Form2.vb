Imports MySql.Data.MySqlClient

Public Class FormLogin
    Dim id_user As String

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbxPass IsNot Nothing And tbxUsername IsNot Nothing Then
            ds.Clear()
            da = New MySqlDataAdapter("select*from tbl_user where username='" & tbxUsername.Text &
                                      "' AND password='" & tbxPass.Text & "';", conn)
            da.Fill(ds, "xxx")
            If ds.Tables("xxx").Rows.Count > 0 Then
                Me.Hide()
                FormDashboard.Show()
            End If
        End If
    End Sub

    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignUp.LinkClicked
        transisi.HideSync(panelLogin)
        transisi.ShowSync(panelSignUp)
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If tbxCreateUname IsNot Nothing And tbxCreatePass IsNot Nothing And cbxRole IsNot Nothing Then
            Dim kode As String
            If cbxRole.SelectedItem = "Admin" Then
                kode = "ADM"
            ElseIf cbxRole.SelectedItem = "Cashier" Then
                kode = "CSR"
            End If

            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_user, 4, 3) AS UNSIGNED)) IS NULL THEN '" & kode & "001' 
                                       ELSE CONCAT('" & kode & "',LPAD(MAX(CAST(SUBSTRING(id_user, 4, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor FROM tbl_user WHERE id_user LIKE '" & kode & "%';", conn)
            da.Fill(ds, "xxx")
            id_user = ds.Tables("xxx").Rows(0).Item(0).ToString

            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_user Values(?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_user", id_user)
            da.SelectCommand.Parameters.AddWithValue("username", tbxCreateUname.Text)
            da.SelectCommand.Parameters.AddWithValue("password", tbxCreatePass.Text)
            da.SelectCommand.Parameters.AddWithValue("role", cbxRole.Text)
            da.Fill(ds, "xxx")

            transisi.HideSync(panelSignUp)
            transisi.ShowSync(panelLogin)
        End If
    End Sub

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        transisi.HideSync(panelSignUp)
        transisi.ShowSync(panelLogin)
    End Sub
End Class