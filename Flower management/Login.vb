Imports System.Data.SqlClient
Public Class Login
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim objcon As SqlConnection = Nothing
    Dim objcmd As SqlCommand = Nothing
    'sign up pannel
    Private Sub BunifuNameTextbox2_Enter(sender As Object, e As EventArgs) Handles fname.Enter
        ' clear the textbox when the textbox get the focus
        Dim name As String = fname.Text
        If name.Trim().ToLower() = "name" Or name.Trim() = "" Then
            fname.Text = ""
            fname.ForeColor = Color.Black
        End If
    End Sub
    Private Sub BunifuNameTextbox2_Leave(sender As Object, e As EventArgs) Handles fname.Leave
        ' when the textbox get lost the focus
        Dim name As String = fname.Text
        If name.Trim().ToLower() = "Name" Or name.Trim() = "" Then
            fname.Text = "Name"
            fname.ForeColor = Color.Crimson
        End If
    End Sub
    Private Sub BunifuPhNumberlTextbox3_Enter(sender As Object, e As EventArgs) Handles PhNumber.Enter
        ' clear the textbox when the textbox get the focus
        Dim name As String = PhNumber.Text
        If name.Trim().ToLower() = "phone number" Or name.Trim() = "" Then
            PhNumber.Text = ""
            PhNumber.ForeColor = Color.Black
        End If
    End Sub
    Private Sub BunifuPhNumberlTextbox3_Leave(sender As Object, e As EventArgs) Handles PhNumber.Leave
        ' when the textbox get lost the focus
        Dim Name As String = PhNumber.Text
        If Name.Trim().ToLower() = "phone number" Or Name.Trim() = "" Then
            PhNumber.Text = "Phone Number"
            PhNumber.ForeColor = Color.Crimson
        End If
    End Sub
    Private Sub username1_Enter(sender As Object, e As EventArgs) Handles username1.Enter
        ' clear the textbox when the textbox get the focus
        Dim username As String = Me.username1.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Me.username1.Text = ""
            Me.username1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub username1_Leave(sender As Object, e As EventArgs) Handles username1.Leave
        ' when the textbox get lost the focus
        Dim username As String = Me.username1.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Me.username1.Text = "Username"
            Me.username1.ForeColor = Color.Crimson

        End If
    End Sub
    Private Sub password1_Enter(sender As Object, e As EventArgs) Handles password1.Enter
        ' when textbox password has focus
        Dim pass As String = password1.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            password1.Text = ""
            password1.ForeColor = Color.Black
            password1.isPassword = True
        End If
    End Sub
    Private Sub password1_Leave(sender As Object, e As EventArgs) Handles password1.Leave
        ' when textbox password lost focus
        Dim pass As String = password1.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            password1.Text = "Password"
            password1.ForeColor = Color.Crimson
            password1.isPassword = False
        End If
    End Sub
    Private Sub BunifuConfPasswordTextbox1_Enter(sender As Object, e As EventArgs) Handles ConfPassword.Enter
        ' when textbox password has focus
        Dim pass As String = ConfPassword.Text
        If pass.Trim().ToLower() = "confirm password" Or pass.Trim() = "" Then
            ConfPassword.Text = ""
            ConfPassword.ForeColor = Color.Black
            ConfPassword.isPassword = True
        End If
    End Sub
    Private Sub BunifuConfPasswordTextbox1_Leave(sender As Object, e As EventArgs) Handles ConfPassword.Leave
        ' when textbox password lost focus
        Dim pass As String = ConfPassword.Text
        If pass.Trim().ToLower() = "Confirm Password" Or pass.Trim() = "" Then
            ConfPassword.Text = "Confirm Password"
            ConfPassword.ForeColor = Color.Crimson
            ConfPassword.isPassword = False
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            password1.isPassword = False
            ConfPassword.isPassword = False

        Else
            password1.isPassword = True
            ConfPassword.isPassword = True

        End If
    End Sub
    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.Click
        sign_in.Visible = True
        sign_up.Visible = False
        forgot_password.Visible = False
        admin_login.Visible = False
    End Sub
    Private Sub BunifuCustomLabel8_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseEnter
        BunifuCustomLabel8.ForeColor = Color.Pink
    End Sub
    Private Sub BunifuCustomLabel8_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseLeave
        BunifuCustomLabel8.ForeColor = Color.Crimson
    End Sub
    'forgot password
    Private Sub Username2_Enter(sender As Object, e As EventArgs) Handles Username2.Enter
        ' clear the textbox when the textbox get the focus
        Dim username As String = Me.Username2.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Me.Username2.Text = ""
            Me.Username2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Username2_Leave(sender As Object, e As EventArgs) Handles Username2.Leave
        ' when the textbox get lost the focus
        Dim username As String = Me.Username2.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Me.Username2.Text = "Username"
            Me.Username2.ForeColor = Color.Crimson
        End If
    End Sub
    Private Sub Password2_Enter(sender As Object, e As EventArgs) Handles Password2.Enter
        ' when textbox password has focus
        Dim pass As String = Password2.Text
        If pass.Trim().ToLower() = "new password" Or pass.Trim() = "" Then
            Password2.Text = ""
            Password2.ForeColor = Color.Black
            Password2.isPassword = True
        End If
    End Sub
    Private Sub Password2_Leave(sender As Object, e As EventArgs) Handles Password2.Leave
        ' when textbox password lost focus
        Dim pass As String = Password2.Text
        If pass.Trim().ToLower() = "New Password" Or pass.Trim() = "" Then
            Password2.Text = "New Password"
            Password2.ForeColor = Color.Crimson
            Password2.isPassword = False
        End If
    End Sub
    Private Sub ConfPassword2_Enter(sender As Object, e As EventArgs) Handles ConfPassword2.Enter
        ' when textbox password has focus
        Dim pass As String = ConfPassword2.Text
        If pass.Trim().ToLower() = "confirm password" Or pass.Trim() = "" Then
            ConfPassword2.Text = ""
            ConfPassword2.ForeColor = Color.Black
            ConfPassword2.isPassword = True
        End If
    End Sub
    Private Sub ConfPassword2_Leave(sender As Object, e As EventArgs) Handles ConfPassword2.Leave
        ' when textbox password lost focus
        Dim pass As String = ConfPassword2.Text
        If pass.Trim().ToLower() = "Confirm Password" Or pass.Trim() = "" Then
            ConfPassword2.Text = "Confirm Password"
            ConfPassword2.ForeColor = Color.Crimson
            ConfPassword2.isPassword = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Password2.isPassword = False
            ConfPassword2.isPassword = False
        Else
            Password2.isPassword = True
            ConfPassword2.isPassword = True
        End If
    End Sub
    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.Click
        sign_in.Visible = True
        forgot_password.Visible = False
        sign_up.Visible = False
        admin_login.Visible = False
    End Sub
    Private Sub BunifuCustomLabel10_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.MouseEnter
        BunifuCustomLabel10.ForeColor = Color.Pink
    End Sub
    Private Sub BunifuCustomLabel10_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.MouseLeave
        BunifuCustomLabel10.ForeColor = Color.Crimson
    End Sub
    'close
    Private Sub BunifuCustomLabel11_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseEnter
        BunifuCustomLabel11.ForeColor = Color.White
    End Sub
    Private Sub BunifuCustomLabel11_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseLeave
        BunifuCustomLabel11.ForeColor = Color.Crimson
    End Sub
    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Application.Exit()
    End Sub
    'admin login
    Private Sub Username3_Enter(sender As Object, e As EventArgs) Handles username3.Enter
        ' clear the textbox when the textbox get the focus
        Dim uname As String = username3.Text
        If uname.Trim().ToLower() = "username" Or uname.Trim() = "" Then
            username3.Text = ""
            username3.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Username3_Leave(sender As Object, e As EventArgs) Handles username3.Leave
        ' when the textbox get lost the focus
        Dim username As String = username3.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            username3.Text = "Username"
            username3.ForeColor = Color.Crimson

        End If
    End Sub
    Private Sub Password3_Enter(sender As Object, e As EventArgs) Handles password3.Enter
        ' when textbox password has focus
        Dim pass As String = password3.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            password3.Text = ""
            password3.ForeColor = Color.Black
            password3.isPassword = True
        End If
    End Sub
    Private Sub Password3_Leave(sender As Object, e As EventArgs) Handles password3.Leave
        ' when textbox password lost focus
        Dim pass As String = password3.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            password3.Text = "Password"
            password3.ForeColor = Color.Crimson
            password3.isPassword = False
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            password3.isPassword = False
        Else
            password3.isPassword = True
        End If
    End Sub
    Private Sub BunifuCustomLabel13_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel13.Click
        sign_in.Visible = True
        forgot_password.Visible = False
        sign_up.Visible = False
        admin_login.Visible = False
    End Sub
    Private Sub BunifuCustomLabel13_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel13.MouseEnter
        BunifuCustomLabel13.ForeColor = Color.Pink
    End Sub
    Private Sub BunifuCustomLabel13_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel13.MouseLeave
        BunifuCustomLabel13.ForeColor = Color.Crimson
    End Sub
    'sign in pannel
    Private Sub BunifuCustomLabel6_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel6.MouseClick
        sign_in.Visible = False
        sign_up.Visible = True
        admin_login.Visible = False
        forgot_password.Visible = False
    End Sub
    Private Sub BunifuCustomLabel6_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.MouseEnter
        BunifuCustomLabel6.ForeColor = Color.Pink
    End Sub
    Private Sub BunifuCustomLabel6_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.MouseLeave
        BunifuCustomLabel6.ForeColor = Color.Crimson
    End Sub
    Private Sub BunifuCustomLabel4_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel4.MouseClick
        sign_in.Visible = False
        forgot_password.Visible = True
        sign_up.Visible = False
        admin_login.Visible = False
    End Sub
    Private Sub BunifuCustomLabel4_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.MouseEnter
        BunifuCustomLabel4.ForeColor = Color.Pink
    End Sub
    Private Sub BunifuCustomLabel4_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.MouseLeave
        BunifuCustomLabel4.ForeColor = Color.Crimson
    End Sub
    Private Sub Username_Enter(sender As Object, e As EventArgs) Handles Username.Enter
        ' clear the textbox when the textbox get the focus
        Dim uname As String = Username.Text
        If uname.Trim().ToLower() = "username" Or uname.Trim() = "" Then
            Username.Text = ""
            Username.ForeColor = Color.Black
        End If
    End Sub
    Private Sub BunifuUsernameTextbox1_Leave(sender As Object, e As EventArgs) Handles Username.Leave
        ' when the textbox get lost the focus
        Dim username As String = Me.Username.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Me.Username.Text = "Username"
            Me.Username.ForeColor = Color.Crimson

        End If
    End Sub
    Private Sub BunifuPasswordTextbox2_Enter(sender As Object, e As EventArgs) Handles Password.Enter
        ' when textbox password has focus
        Dim pass As String = Password.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            Password.Text = ""
            Password.ForeColor = Color.Black
            Password.isPassword = True
        End If
    End Sub
    Private Sub BunifuPasswordTextbox2_Leave(sender As Object, e As EventArgs) Handles Password.Leave
        ' when textbox password lost focus
        Dim pass As String = Password.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            Password.Text = "Password"
            Password.ForeColor = Color.Crimson
            Password.isPassword = False
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.isPassword = False
        Else
            Password.isPassword = True
        End If
    End Sub
    Private Sub BunifuCustomLabel14_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel14.Click
        sign_in.Visible = False
        sign_up.Visible = False
        admin_login.Visible = True
        forgot_password.Visible = False
    End Sub
    Private Sub BunifuCustomLabel14_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel14.MouseEnter
        BunifuCustomLabel14.ForeColor = Color.Pink
    End Sub
    Private Sub BunifuCustomLabel14_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel14.MouseLeave
        BunifuCustomLabel14.ForeColor = Color.Crimson
    End Sub
    Private Sub loginn_Click(sender As Object, e As EventArgs) Handles loginn.Click
        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from signin where Username ='" & Username.Text & "' AND Password ='" & Password.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                Homepage.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                Username.Text = ""
                Password.Text = ""
            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        If password1.Text <> ConfPassword.Text Then
            MsgBox("Password Does Not Match")
            password1.Text = ""
            ConfPassword.Text = ""
            Exit Sub
        End If

        Try

            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from signin where Phnumber='" & PhNumber.Text & "'  AND Username='" & username1.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("User Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO signin values('" & fname.Text & "','" & PhNumber.Text & "','" & username1.Text & "','" & password1.Text & "')", con)
                If (fname.Text = "" And PhNumber.Text = "" And Username.Text = "" And Password.Text = "" And ConfPassword.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    sign_up.Visible = False
                    sign_in.Visible = True
                    fname.Text = ""
                    PhNumber.Text = ""
                    username1.Text = ""
                    password1.Text = ""
                    ConfPassword.Text = ""
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Password2.Text <> ConfPassword2.Text Then
            MsgBox("Password Does Not Match")
            Password2.Text = ""
            ConfPassword2.Text = ""
            Exit Sub
        End If

        If Password2.Text = " " And ConfPassword2.Text = " " Then
            MsgBox("Please Enter Details", MsgBoxStyle.Information, "Data Updation")
            Exit Sub
        End If
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True"
        con.Open()
        cmd = New SqlCommand(" update signin Set Password ='" & Password2.Text & "' WHERE Username ='" & Username2.Text & "' ", con)
        cmd.ExecuteNonQuery()
        MsgBox("Password Updated")
        con.Close()
        sign_in.Visible = True
        sign_up.Visible = False
        forgot_password.Visible = False
    End Sub

    Private Sub login2_Click(sender As Object, e As EventArgs) Handles login2.Click
        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from admin where username ='" & username3.Text & "' AND password ='" & password3.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                admin.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid Login Please Check!")
                username3.Text = ""
                password3.Text = ""
            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub


End Class