<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Me.PanelLocation = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.btnReservation = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnLocation = New Guna.UI.WinForms.GunaGradientButton()
        Me.PanelReservation = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.transisi = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaCirclePictureBox7 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaCirclePictureBox6 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox5 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox4 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.linkLogout = New Guna.UI.WinForms.GunaLinkLabel()
        Me.PanelLocation.SuspendLayout()
        Me.PanelReservation.SuspendLayout()
        CType(Me.GunaCirclePictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLocation
        '
        Me.PanelLocation.BackColor = System.Drawing.Color.Transparent
        Me.PanelLocation.BaseColor = System.Drawing.Color.Beige
        Me.PanelLocation.Controls.Add(Me.GunaLabel10)
        Me.PanelLocation.Controls.Add(Me.GunaCirclePictureBox7)
        Me.PanelLocation.Controls.Add(Me.GunaLabel11)
        Me.PanelLocation.Controls.Add(Me.GunaPictureBox3)
        Me.PanelLocation.Controls.Add(Me.GunaPictureBox2)
        Me.PanelLocation.Controls.Add(Me.GunaPictureBox1)
        Me.transisi.SetDecoration(Me.PanelLocation, Guna.UI.Animation.DecorationType.None)
        Me.PanelLocation.Location = New System.Drawing.Point(265, 29)
        Me.PanelLocation.Name = "PanelLocation"
        Me.PanelLocation.Radius = 10
        Me.PanelLocation.ShadowColor = System.Drawing.Color.Black
        Me.PanelLocation.Size = New System.Drawing.Size(492, 389)
        Me.PanelLocation.TabIndex = 31
        Me.PanelLocation.Visible = False
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel10, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(95, 320)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(301, 25)
        Me.GunaLabel10.TabIndex = 6
        Me.GunaLabel10.Text = "Jam Buka (10.00 WIB - 21.00 WIB)"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel11, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(47, 250)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(418, 25)
        Me.GunaLabel11.TabIndex = 4
        Me.GunaLabel11.Text = "Jl. Rungkut Madya No. 203, Rungkut, Surabaya"
        '
        'btnReservation
        '
        Me.btnReservation.AnimationHoverSpeed = 0.07!
        Me.btnReservation.AnimationSpeed = 0.03!
        Me.btnReservation.BackColor = System.Drawing.Color.Transparent
        Me.btnReservation.BaseColor1 = System.Drawing.Color.DarkSlateBlue
        Me.btnReservation.BaseColor2 = System.Drawing.Color.LightSeaGreen
        Me.btnReservation.BorderColor = System.Drawing.Color.Black
        Me.transisi.SetDecoration(Me.btnReservation, Guna.UI.Animation.DecorationType.None)
        Me.btnReservation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReservation.FocusedColor = System.Drawing.Color.Empty
        Me.btnReservation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReservation.ForeColor = System.Drawing.Color.White
        Me.btnReservation.Image = Nothing
        Me.btnReservation.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReservation.Location = New System.Drawing.Point(46, 279)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnReservation.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReservation.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReservation.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReservation.OnHoverImage = Nothing
        Me.btnReservation.OnPressedColor = System.Drawing.Color.Black
        Me.btnReservation.Radius = 20
        Me.btnReservation.Size = New System.Drawing.Size(160, 42)
        Me.btnReservation.TabIndex = 3
        Me.btnReservation.Text = "Reservation"
        Me.btnReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLocation
        '
        Me.btnLocation.AnimationHoverSpeed = 0.07!
        Me.btnLocation.AnimationSpeed = 0.03!
        Me.btnLocation.BackColor = System.Drawing.Color.Transparent
        Me.btnLocation.BaseColor1 = System.Drawing.Color.DarkSlateBlue
        Me.btnLocation.BaseColor2 = System.Drawing.Color.LightSeaGreen
        Me.btnLocation.BorderColor = System.Drawing.Color.Black
        Me.transisi.SetDecoration(Me.btnLocation, Guna.UI.Animation.DecorationType.None)
        Me.btnLocation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLocation.FocusedColor = System.Drawing.Color.Empty
        Me.btnLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLocation.ForeColor = System.Drawing.Color.White
        Me.btnLocation.Image = Nothing
        Me.btnLocation.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLocation.Location = New System.Drawing.Point(46, 342)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnLocation.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLocation.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLocation.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLocation.OnHoverImage = Nothing
        Me.btnLocation.OnPressedColor = System.Drawing.Color.Black
        Me.btnLocation.Radius = 20
        Me.btnLocation.Size = New System.Drawing.Size(160, 42)
        Me.btnLocation.TabIndex = 9
        Me.btnLocation.Text = "Location"
        Me.btnLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelReservation
        '
        Me.PanelReservation.BackColor = System.Drawing.Color.Transparent
        Me.PanelReservation.BaseColor = System.Drawing.Color.Beige
        Me.PanelReservation.Controls.Add(Me.GunaLabel9)
        Me.PanelReservation.Controls.Add(Me.GunaLabel8)
        Me.PanelReservation.Controls.Add(Me.GunaLabel7)
        Me.PanelReservation.Controls.Add(Me.GunaLabel6)
        Me.PanelReservation.Controls.Add(Me.GunaCirclePictureBox6)
        Me.PanelReservation.Controls.Add(Me.GunaCirclePictureBox5)
        Me.PanelReservation.Controls.Add(Me.GunaCirclePictureBox4)
        Me.PanelReservation.Controls.Add(Me.GunaCirclePictureBox3)
        Me.PanelReservation.Controls.Add(Me.GunaLabel5)
        Me.PanelReservation.Controls.Add(Me.GunaLabel4)
        Me.PanelReservation.Controls.Add(Me.GunaCirclePictureBox2)
        Me.PanelReservation.Controls.Add(Me.GunaLabel3)
        Me.PanelReservation.Controls.Add(Me.GunaLabel2)
        Me.transisi.SetDecoration(Me.PanelReservation, Guna.UI.Animation.DecorationType.None)
        Me.PanelReservation.Location = New System.Drawing.Point(265, 29)
        Me.PanelReservation.Name = "PanelReservation"
        Me.PanelReservation.Radius = 10
        Me.PanelReservation.ShadowColor = System.Drawing.Color.Black
        Me.PanelReservation.Size = New System.Drawing.Size(492, 389)
        Me.PanelReservation.TabIndex = 15
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel9, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(396, 305)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(50, 15)
        Me.GunaLabel9.TabIndex = 30
        Me.GunaLabel9.Text = "@s_cafe"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel8, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(288, 305)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(50, 15)
        Me.GunaLabel8.TabIndex = 29
        Me.GunaLabel8.Text = "@s_cafe"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel7, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(158, 305)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(50, 15)
        Me.GunaLabel7.TabIndex = 28
        Me.GunaLabel7.Text = "@s_cafe"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(40, 305)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(50, 15)
        Me.GunaLabel6.TabIndex = 27
        Me.GunaLabel6.Text = "@s_cafe"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel5, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(174, 201)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(167, 15)
        Me.GunaLabel5.TabIndex = 22
        Me.GunaLabel5.Text = "You can visit our social media"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(88, 148)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(101, 15)
        Me.GunaLabel4.TabIndex = 21
        Me.GunaLabel4.Text = "0813 - 6570 - 6378"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(37, 99)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(371, 15)
        Me.GunaLabel3.TabIndex = 18
        Me.GunaLabel3.Text = "To reserve a place at our café, you can contact the following contact :"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(172, 38)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(173, 28)
        Me.GunaLabel2.TabIndex = 17
        Me.GunaLabel2.Text = "Reservation Info"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.transisi.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(55, 230)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(140, 22)
        Me.GunaLabel1.TabIndex = 16
        Me.GunaLabel1.Text = "About Our Cafe"
        '
        'transisi
        '
        Me.transisi.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.transisi.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.transisi.DefaultAnimation = Animation2
        Me.transisi.TimeStep = 0.2!
        '
        'GunaCirclePictureBox7
        '
        Me.GunaCirclePictureBox7.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaCirclePictureBox7, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox7.Image = Global.guna_form.My.Resources.Resources._35c11477d386737c8890f6cc0c0cd2d7
        Me.GunaCirclePictureBox7.Location = New System.Drawing.Point(212, 177)
        Me.GunaCirclePictureBox7.Name = "GunaCirclePictureBox7"
        Me.GunaCirclePictureBox7.Size = New System.Drawing.Size(68, 70)
        Me.GunaCirclePictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox7.TabIndex = 5
        Me.GunaCirclePictureBox7.TabStop = False
        Me.GunaCirclePictureBox7.UseTransfarantBackground = False
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaPictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox3.Image = Global.guna_form.My.Resources.Resources.c56fb3ba335505a88fbfcba7ab63d618
        Me.GunaPictureBox3.Location = New System.Drawing.Point(336, 25)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(129, 120)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox3.TabIndex = 2
        Me.GunaPictureBox3.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaPictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox2.Image = Global.guna_form.My.Resources.Resources.fb50f0543aa72a4b35e1077ec58571ce
        Me.GunaPictureBox2.Location = New System.Drawing.Point(177, 25)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(129, 120)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 1
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox1.Image = Global.guna_form.My.Resources.Resources._1defe1c08e139a4a534f23676e1a534b
        Me.GunaPictureBox1.Location = New System.Drawing.Point(21, 25)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(129, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaCirclePictureBox6
        '
        Me.GunaCirclePictureBox6.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaCirclePictureBox6, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox6.Image = Global.guna_form.My.Resources.Resources._5545a2a9ce938ec70e0941cdd7a82105
        Me.GunaCirclePictureBox6.Location = New System.Drawing.Point(396, 250)
        Me.GunaCirclePictureBox6.Name = "GunaCirclePictureBox6"
        Me.GunaCirclePictureBox6.Size = New System.Drawing.Size(50, 52)
        Me.GunaCirclePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox6.TabIndex = 26
        Me.GunaCirclePictureBox6.TabStop = False
        Me.GunaCirclePictureBox6.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox5
        '
        Me.GunaCirclePictureBox5.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaCirclePictureBox5, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox5.Image = Global.guna_form.My.Resources.Resources._8e9be8eab623d1a87cd696a5918af8af
        Me.GunaCirclePictureBox5.Location = New System.Drawing.Point(288, 250)
        Me.GunaCirclePictureBox5.Name = "GunaCirclePictureBox5"
        Me.GunaCirclePictureBox5.Size = New System.Drawing.Size(50, 52)
        Me.GunaCirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox5.TabIndex = 25
        Me.GunaCirclePictureBox5.TabStop = False
        Me.GunaCirclePictureBox5.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox4
        '
        Me.GunaCirclePictureBox4.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaCirclePictureBox4, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox4.Image = Global.guna_form.My.Resources.Resources.cc316f97197528e5e26e613a93ab16a4
        Me.GunaCirclePictureBox4.Location = New System.Drawing.Point(158, 250)
        Me.GunaCirclePictureBox4.Name = "GunaCirclePictureBox4"
        Me.GunaCirclePictureBox4.Size = New System.Drawing.Size(50, 52)
        Me.GunaCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox4.TabIndex = 24
        Me.GunaCirclePictureBox4.TabStop = False
        Me.GunaCirclePictureBox4.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaCirclePictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox3.Image = Global.guna_form.My.Resources.Resources.f41e2dab621c1ee5253cef74e3642fcf
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(40, 250)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(50, 52)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox3.TabIndex = 23
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaCirclePictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox2.Image = Global.guna_form.My.Resources.Resources.d8d4791ec64f0e040111ef014475f2ba
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(40, 134)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(42, 43)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 20
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.transisi.SetDecoration(Me.GunaCirclePictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox1.Image = Global.guna_form.My.Resources.Resources.e99414070fabc44ae9ed2b470c71300a
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(25, 29)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(188, 187)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox1.TabIndex = 2
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'linkLogout
        '
        Me.linkLogout.AutoSize = True
        Me.transisi.SetDecoration(Me.linkLogout, Guna.UI.Animation.DecorationType.None)
        Me.linkLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkLogout.Location = New System.Drawing.Point(12, 426)
        Me.linkLogout.Name = "linkLogout"
        Me.linkLogout.Size = New System.Drawing.Size(47, 15)
        Me.linkLogout.TabIndex = 32
        Me.linkLogout.TabStop = True
        Me.linkLogout.Text = "LogOut"
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.linkLogout)
        Me.Controls.Add(Me.PanelLocation)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.PanelReservation)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.btnReservation)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.transisi.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDashboard"
        Me.Text = "Form1"
        Me.PanelLocation.ResumeLayout(False)
        Me.PanelLocation.PerformLayout()
        Me.PanelReservation.ResumeLayout(False)
        Me.PanelReservation.PerformLayout()
        CType(Me.GunaCirclePictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnReservation As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnLocation As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents PanelReservation As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox4 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox5 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox6 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PanelLocation As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaCirclePictureBox7 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Public WithEvents transisi As Guna.UI.WinForms.GunaTransition
    Friend WithEvents linkLogout As Guna.UI.WinForms.GunaLinkLabel
End Class
