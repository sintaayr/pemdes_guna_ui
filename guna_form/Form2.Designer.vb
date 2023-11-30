<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.panelLogin = New Guna.UI.WinForms.GunaShadowPanel()
        Me.tbxPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.linkSignUp = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogin = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.panelSignUp = New Guna.UI.WinForms.GunaShadowPanel()
        Me.cbxRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.linkLogin = New Guna.UI.WinForms.GunaLinkLabel()
        Me.tbxCreatePass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxCreateUname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSignUp = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.transisi = New Guna.UI.WinForms.GunaTransition(Me.components)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin.SuspendLayout()
        Me.panelSignUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox1.Image = Global.guna_form.My.Resources.Resources.dbcc3155fe447fdfa63a9d62aa6a341d
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(339, 450)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.Transparent
        Me.panelLogin.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.panelLogin.Controls.Add(Me.tbxPass)
        Me.panelLogin.Controls.Add(Me.tbxUsername)
        Me.panelLogin.Controls.Add(Me.linkSignUp)
        Me.panelLogin.Controls.Add(Me.GunaLabel4)
        Me.panelLogin.Controls.Add(Me.btnLogin)
        Me.panelLogin.Controls.Add(Me.GunaLabel3)
        Me.panelLogin.Controls.Add(Me.GunaLabel2)
        Me.panelLogin.Controls.Add(Me.GunaLabel1)
        Me.transisi.SetDecoration(Me.panelLogin, Guna.UI.Animation.DecorationType.None)
        Me.panelLogin.Location = New System.Drawing.Point(428, 25)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Radius = 20
        Me.panelLogin.ShadowColor = System.Drawing.Color.Black
        Me.panelLogin.Size = New System.Drawing.Size(316, 388)
        Me.panelLogin.TabIndex = 1
        '
        'tbxPass
        '
        Me.tbxPass.BorderRadius = 5
        Me.tbxPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transisi.SetDecoration(Me.tbxPass, Guna.UI.Animation.DecorationType.None)
        Me.tbxPass.DefaultText = ""
        Me.tbxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxPass.Location = New System.Drawing.Point(28, 202)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.PlaceholderText = "Enter your password"
        Me.tbxPass.SelectedText = ""
        Me.tbxPass.Size = New System.Drawing.Size(260, 36)
        Me.tbxPass.TabIndex = 31
        '
        'tbxUsername
        '
        Me.tbxUsername.BorderRadius = 5
        Me.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transisi.SetDecoration(Me.tbxUsername, Guna.UI.Animation.DecorationType.None)
        Me.tbxUsername.DefaultText = ""
        Me.tbxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxUsername.Location = New System.Drawing.Point(28, 124)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxUsername.PlaceholderText = "Enter your username"
        Me.tbxUsername.SelectedText = ""
        Me.tbxUsername.Size = New System.Drawing.Size(260, 36)
        Me.tbxUsername.TabIndex = 30
        '
        'linkSignUp
        '
        Me.linkSignUp.AutoSize = True
        Me.transisi.SetDecoration(Me.linkSignUp, Guna.UI.Animation.DecorationType.None)
        Me.linkSignUp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkSignUp.Location = New System.Drawing.Point(243, 339)
        Me.linkSignUp.Name = "linkSignUp"
        Me.linkSignUp.Size = New System.Drawing.Size(48, 15)
        Me.linkSignUp.TabIndex = 24
        Me.linkSignUp.TabStop = True
        Me.linkSignUp.Text = "Sign Up"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Poor Richard", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(104, 336)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(143, 18)
        Me.GunaLabel4.TabIndex = 23
        Me.GunaLabel4.Text = "Don't have any account?"
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor1 = System.Drawing.Color.Goldenrod
        Me.btnLogin.BaseColor2 = System.Drawing.Color.RoyalBlue
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.transisi.SetDecoration(Me.btnLogin, Guna.UI.Animation.DecorationType.None)
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(33, 268)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnLogin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 10
        Me.btnLogin.Size = New System.Drawing.Size(255, 42)
        Me.btnLogin.TabIndex = 22
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(29, 180)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(72, 19)
        Me.GunaLabel3.TabIndex = 21
        Me.GunaLabel3.Text = "Password"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(29, 102)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(78, 19)
        Me.GunaLabel2.TabIndex = 20
        Me.GunaLabel2.Text = "Username"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(118, 57)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(70, 22)
        Me.GunaLabel1.TabIndex = 17
        Me.GunaLabel1.Text = "LOGIN"
        '
        'panelSignUp
        '
        Me.panelSignUp.BackColor = System.Drawing.Color.Transparent
        Me.panelSignUp.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.panelSignUp.Controls.Add(Me.cbxRole)
        Me.panelSignUp.Controls.Add(Me.GunaLabel5)
        Me.panelSignUp.Controls.Add(Me.linkLogin)
        Me.panelSignUp.Controls.Add(Me.tbxCreatePass)
        Me.panelSignUp.Controls.Add(Me.tbxCreateUname)
        Me.panelSignUp.Controls.Add(Me.btnSignUp)
        Me.panelSignUp.Controls.Add(Me.GunaLabel6)
        Me.panelSignUp.Controls.Add(Me.GunaLabel7)
        Me.panelSignUp.Controls.Add(Me.GunaLabel8)
        Me.transisi.SetDecoration(Me.panelSignUp, Guna.UI.Animation.DecorationType.None)
        Me.panelSignUp.Location = New System.Drawing.Point(428, 25)
        Me.panelSignUp.Name = "panelSignUp"
        Me.panelSignUp.Radius = 20
        Me.panelSignUp.ShadowColor = System.Drawing.Color.Black
        Me.panelSignUp.Size = New System.Drawing.Size(316, 388)
        Me.panelSignUp.TabIndex = 25
        Me.panelSignUp.Visible = False
        '
        'cbxRole
        '
        Me.cbxRole.BackColor = System.Drawing.Color.Transparent
        Me.cbxRole.BorderRadius = 5
        Me.transisi.SetDecoration(Me.cbxRole, Guna.UI.Animation.DecorationType.None)
        Me.cbxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRole.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxRole.ItemHeight = 30
        Me.cbxRole.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.cbxRole.Location = New System.Drawing.Point(33, 242)
        Me.cbxRole.Name = "cbxRole"
        Me.cbxRole.Size = New System.Drawing.Size(255, 36)
        Me.cbxRole.TabIndex = 29
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel5, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(29, 220)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(40, 19)
        Me.GunaLabel5.TabIndex = 27
        Me.GunaLabel5.Text = "Role"
        '
        'linkLogin
        '
        Me.linkLogin.AutoSize = True
        Me.transisi.SetDecoration(Me.linkLogin, Guna.UI.Animation.DecorationType.None)
        Me.linkLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkLogin.Location = New System.Drawing.Point(240, 350)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(37, 15)
        Me.linkLogin.TabIndex = 26
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Login"
        '
        'tbxCreatePass
        '
        Me.tbxCreatePass.BorderRadius = 5
        Me.tbxCreatePass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transisi.SetDecoration(Me.tbxCreatePass, Guna.UI.Animation.DecorationType.None)
        Me.tbxCreatePass.DefaultText = ""
        Me.tbxCreatePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxCreatePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxCreatePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxCreatePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxCreatePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxCreatePass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxCreatePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxCreatePass.Location = New System.Drawing.Point(28, 173)
        Me.tbxCreatePass.Name = "tbxCreatePass"
        Me.tbxCreatePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxCreatePass.PlaceholderText = "Create Password"
        Me.tbxCreatePass.SelectedText = ""
        Me.tbxCreatePass.Size = New System.Drawing.Size(260, 35)
        Me.tbxCreatePass.TabIndex = 25
        '
        'tbxCreateUname
        '
        Me.tbxCreateUname.BorderRadius = 5
        Me.tbxCreateUname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transisi.SetDecoration(Me.tbxCreateUname, Guna.UI.Animation.DecorationType.None)
        Me.tbxCreateUname.DefaultText = ""
        Me.tbxCreateUname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxCreateUname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxCreateUname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxCreateUname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxCreateUname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxCreateUname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxCreateUname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxCreateUname.Location = New System.Drawing.Point(28, 105)
        Me.tbxCreateUname.Name = "tbxCreateUname"
        Me.tbxCreateUname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxCreateUname.PlaceholderText = "Create Username"
        Me.tbxCreateUname.SelectedText = ""
        Me.tbxCreateUname.Size = New System.Drawing.Size(260, 36)
        Me.tbxCreateUname.TabIndex = 24
        '
        'btnSignUp
        '
        Me.btnSignUp.AnimationHoverSpeed = 0.07!
        Me.btnSignUp.AnimationSpeed = 0.03!
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BaseColor1 = System.Drawing.Color.Goldenrod
        Me.btnSignUp.BaseColor2 = System.Drawing.Color.RoyalBlue
        Me.btnSignUp.BorderColor = System.Drawing.Color.Black
        Me.transisi.SetDecoration(Me.btnSignUp, Guna.UI.Animation.DecorationType.None)
        Me.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSignUp.FocusedColor = System.Drawing.Color.Empty
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Image = Nothing
        Me.btnSignUp.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSignUp.Location = New System.Drawing.Point(33, 295)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSignUp.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSignUp.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSignUp.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSignUp.OnHoverImage = Nothing
        Me.btnSignUp.OnPressedColor = System.Drawing.Color.Black
        Me.btnSignUp.Radius = 10
        Me.btnSignUp.Size = New System.Drawing.Size(255, 42)
        Me.btnSignUp.TabIndex = 22
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(29, 151)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(72, 19)
        Me.GunaLabel6.TabIndex = 21
        Me.GunaLabel6.Text = "Password"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel7, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel7.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(29, 83)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(78, 19)
        Me.GunaLabel7.TabIndex = 20
        Me.GunaLabel7.Text = "Username"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel8, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel8.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(118, 41)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(82, 22)
        Me.GunaLabel8.TabIndex = 17
        Me.GunaLabel8.Text = "SIGN UP"
        '
        'transisi
        '
        Me.transisi.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.transisi.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.transisi.DefaultAnimation = Animation1
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelSignUp)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.transisi.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.Text = "Form2"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        Me.panelSignUp.ResumeLayout(False)
        Me.panelSignUp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents tbxPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents linkSignUp As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panelSignUp As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btnSignUp As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents transisi As Guna.UI.WinForms.GunaTransition
    Friend WithEvents tbxCreateUname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxRole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents linkLogin As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents tbxCreatePass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxUsername As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents panelLogin As Guna.UI.WinForms.GunaShadowPanel
End Class
