<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbVersion = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStatWeapons = New System.Windows.Forms.Label()
        Me.lblStatShields = New System.Windows.Forms.Label()
        Me.lblCharShip = New System.Windows.Forms.Label()
        Me.lblWeaponsPlayer = New System.Windows.Forms.Label()
        Me.lblShieldsPlayer = New System.Windows.Forms.Label()
        Me.lblCharCaptain = New System.Windows.Forms.Label()
        Me.lblCharScience = New System.Windows.Forms.Label()
        Me.lblCharMedical = New System.Windows.Forms.Label()
        Me.lblCharEngineer = New System.Windows.Forms.Label()
        Me.lblCharSecurity = New System.Windows.Forms.Label()
        Me.lblCharGuard1 = New System.Windows.Forms.Label()
        Me.lblCharGuard2 = New System.Windows.Forms.Label()
        Me.lblStatSkill = New System.Windows.Forms.Label()
        Me.lblStatStamina = New System.Windows.Forms.Label()
        Me.cbCaptain = New System.Windows.Forms.CheckBox()
        Me.cbScience = New System.Windows.Forms.CheckBox()
        Me.cbMedical = New System.Windows.Forms.CheckBox()
        Me.cbEngineer = New System.Windows.Forms.CheckBox()
        Me.cbSecurity = New System.Windows.Forms.CheckBox()
        Me.cbGuard1 = New System.Windows.Forms.CheckBox()
        Me.cbGuard2 = New System.Windows.Forms.CheckBox()
        Me.lblStatLuck = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.tmrMessage = New System.Windows.Forms.Timer(Me.components)
        Me.lblSkillCaptain = New System.Windows.Forms.Label()
        Me.lblSkillScience = New System.Windows.Forms.Label()
        Me.lblSkillMedical = New System.Windows.Forms.Label()
        Me.lblSkillEngineer = New System.Windows.Forms.Label()
        Me.lblSkillSecurity = New System.Windows.Forms.Label()
        Me.lblSkillGuard1 = New System.Windows.Forms.Label()
        Me.lblSkillGuard2 = New System.Windows.Forms.Label()
        Me.lblStaminaCaptain = New System.Windows.Forms.Label()
        Me.lblStaminaScience = New System.Windows.Forms.Label()
        Me.lblStaminaMedical = New System.Windows.Forms.Label()
        Me.lblStaminaEngineer = New System.Windows.Forms.Label()
        Me.lblStaminaSecurity = New System.Windows.Forms.Label()
        Me.lblStaminaGuard1 = New System.Windows.Forms.Label()
        Me.lblStaminaGuard2 = New System.Windows.Forms.Label()
        Me.lblLuck = New System.Windows.Forms.Label()
        Me.btnNewBuild = New System.Windows.Forms.Button()
        Me.btnAddEnemyShip = New System.Windows.Forms.Button()
        Me.btnFirePlayer = New System.Windows.Forms.Button()
        Me.btnFireEnemy = New System.Windows.Forms.Button()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.pnlPlusMinus = New System.Windows.Forms.Panel()
        Me.lblOppStamina = New System.Windows.Forms.Label()
        Me.lblOppSkill = New System.Windows.Forms.Label()
        Me.btnAddEnemyFighter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRoll1 = New System.Windows.Forms.Label()
        Me.lblRoll2 = New System.Windows.Forms.Label()
        Me.lblRoll3 = New System.Windows.Forms.Label()
        Me.btnFightPlayer = New System.Windows.Forms.Button()
        Me.btnFightEnemy = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.pnlPlusMinus.SuspendLayout
        Me.SuspendLayout
        '
        'tbVersion
        '
        Me.tbVersion.Location = New System.Drawing.Point(165, 10)
        Me.tbVersion.MaxLength = 9
        Me.tbVersion.Name = "tbVersion"
        Me.tbVersion.Size = New System.Drawing.Size(26, 20)
        Me.tbVersion.TabIndex = 0
        Me.tbVersion.TabStop = false
        Me.tbVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = true
        Me.lblTitle.Location = New System.Drawing.Point(13, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(153, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Starship ""Traveller""   --   Build#"
        '
        'lblStatWeapons
        '
        Me.lblStatWeapons.AutoSize = true
        Me.lblStatWeapons.Location = New System.Drawing.Point(12, 66)
        Me.lblStatWeapons.Name = "lblStatWeapons"
        Me.lblStatWeapons.Size = New System.Drawing.Size(97, 13)
        Me.lblStatWeapons.TabIndex = 2
        Me.lblStatWeapons.Text = "Weapon Strength: "
        '
        'lblStatShields
        '
        Me.lblStatShields.AutoSize = true
        Me.lblStatShields.Location = New System.Drawing.Point(24, 82)
        Me.lblStatShields.Name = "lblStatShields"
        Me.lblStatShields.Size = New System.Drawing.Size(85, 13)
        Me.lblStatShields.TabIndex = 3
        Me.lblStatShields.Text = "Shield Strength: "
        '
        'lblCharShip
        '
        Me.lblCharShip.AutoSize = true
        Me.lblCharShip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCharShip.Location = New System.Drawing.Point(106, 50)
        Me.lblCharShip.Name = "lblCharShip"
        Me.lblCharShip.Size = New System.Drawing.Size(53, 13)
        Me.lblCharShip.TabIndex = 4
        Me.lblCharShip.Text = "Your Ship"
        Me.lblCharShip.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWeaponsPlayer
        '
        Me.lblWeaponsPlayer.Location = New System.Drawing.Point(120, 66)
        Me.lblWeaponsPlayer.Name = "lblWeaponsPlayer"
        Me.lblWeaponsPlayer.Size = New System.Drawing.Size(19, 13)
        Me.lblWeaponsPlayer.TabIndex = 5
        Me.lblWeaponsPlayer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShieldsPlayer
        '
        Me.lblShieldsPlayer.Location = New System.Drawing.Point(120, 82)
        Me.lblShieldsPlayer.Name = "lblShieldsPlayer"
        Me.lblShieldsPlayer.Size = New System.Drawing.Size(19, 13)
        Me.lblShieldsPlayer.TabIndex = 6
        Me.lblShieldsPlayer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharCaptain
        '
        Me.lblCharCaptain.Location = New System.Drawing.Point(12, 123)
        Me.lblCharCaptain.Name = "lblCharCaptain"
        Me.lblCharCaptain.Size = New System.Drawing.Size(100, 13)
        Me.lblCharCaptain.TabIndex = 7
        Me.lblCharCaptain.Text = "Captain:"
        Me.lblCharCaptain.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharScience
        '
        Me.lblCharScience.Location = New System.Drawing.Point(12, 136)
        Me.lblCharScience.Name = "lblCharScience"
        Me.lblCharScience.Size = New System.Drawing.Size(100, 13)
        Me.lblCharScience.TabIndex = 8
        Me.lblCharScience.Text = "Science Officer:"
        Me.lblCharScience.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharMedical
        '
        Me.lblCharMedical.Location = New System.Drawing.Point(12, 149)
        Me.lblCharMedical.Name = "lblCharMedical"
        Me.lblCharMedical.Size = New System.Drawing.Size(100, 13)
        Me.lblCharMedical.TabIndex = 9
        Me.lblCharMedical.Text = "Medical Officer:"
        Me.lblCharMedical.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharEngineer
        '
        Me.lblCharEngineer.AutoSize = true
        Me.lblCharEngineer.Location = New System.Drawing.Point(12, 162)
        Me.lblCharEngineer.Name = "lblCharEngineer"
        Me.lblCharEngineer.Size = New System.Drawing.Size(100, 13)
        Me.lblCharEngineer.TabIndex = 10
        Me.lblCharEngineer.Text = "Engineering Officer:"
        Me.lblCharEngineer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharSecurity
        '
        Me.lblCharSecurity.Location = New System.Drawing.Point(12, 175)
        Me.lblCharSecurity.Name = "lblCharSecurity"
        Me.lblCharSecurity.Size = New System.Drawing.Size(100, 13)
        Me.lblCharSecurity.TabIndex = 11
        Me.lblCharSecurity.Text = "Security Officer:"
        Me.lblCharSecurity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharGuard1
        '
        Me.lblCharGuard1.Location = New System.Drawing.Point(12, 188)
        Me.lblCharGuard1.Name = "lblCharGuard1"
        Me.lblCharGuard1.Size = New System.Drawing.Size(100, 13)
        Me.lblCharGuard1.TabIndex = 12
        Me.lblCharGuard1.Text = "Security Guard 1:"
        Me.lblCharGuard1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharGuard2
        '
        Me.lblCharGuard2.Location = New System.Drawing.Point(13, 201)
        Me.lblCharGuard2.Name = "lblCharGuard2"
        Me.lblCharGuard2.Size = New System.Drawing.Size(99, 13)
        Me.lblCharGuard2.TabIndex = 13
        Me.lblCharGuard2.Text = "Security Guard 2:"
        Me.lblCharGuard2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStatSkill
        '
        Me.lblStatSkill.AutoSize = true
        Me.lblStatSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStatSkill.Location = New System.Drawing.Point(115, 110)
        Me.lblStatSkill.Name = "lblStatSkill"
        Me.lblStatSkill.Size = New System.Drawing.Size(26, 13)
        Me.lblStatSkill.TabIndex = 14
        Me.lblStatSkill.Text = "Skill"
        '
        'lblStatStamina
        '
        Me.lblStatStamina.AutoSize = true
        Me.lblStatStamina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStatStamina.Location = New System.Drawing.Point(147, 110)
        Me.lblStatStamina.Name = "lblStatStamina"
        Me.lblStatStamina.Size = New System.Drawing.Size(45, 13)
        Me.lblStatStamina.TabIndex = 15
        Me.lblStatStamina.Text = "Stamina"
        '
        'cbCaptain
        '
        Me.cbCaptain.AutoSize = true
        Me.cbCaptain.Location = New System.Drawing.Point(191, 123)
        Me.cbCaptain.Name = "cbCaptain"
        Me.cbCaptain.Size = New System.Drawing.Size(15, 14)
        Me.cbCaptain.TabIndex = 16
        Me.cbCaptain.UseVisualStyleBackColor = true
        '
        'cbScience
        '
        Me.cbScience.AutoSize = true
        Me.cbScience.Location = New System.Drawing.Point(191, 136)
        Me.cbScience.Name = "cbScience"
        Me.cbScience.Size = New System.Drawing.Size(15, 14)
        Me.cbScience.TabIndex = 17
        Me.cbScience.UseVisualStyleBackColor = true
        '
        'cbMedical
        '
        Me.cbMedical.AutoSize = true
        Me.cbMedical.Location = New System.Drawing.Point(191, 149)
        Me.cbMedical.Name = "cbMedical"
        Me.cbMedical.Size = New System.Drawing.Size(15, 14)
        Me.cbMedical.TabIndex = 18
        Me.cbMedical.UseVisualStyleBackColor = true
        '
        'cbEngineer
        '
        Me.cbEngineer.AutoSize = true
        Me.cbEngineer.Location = New System.Drawing.Point(191, 162)
        Me.cbEngineer.Name = "cbEngineer"
        Me.cbEngineer.Size = New System.Drawing.Size(15, 14)
        Me.cbEngineer.TabIndex = 19
        Me.cbEngineer.UseVisualStyleBackColor = true
        '
        'cbSecurity
        '
        Me.cbSecurity.AutoSize = true
        Me.cbSecurity.Location = New System.Drawing.Point(191, 175)
        Me.cbSecurity.Name = "cbSecurity"
        Me.cbSecurity.Size = New System.Drawing.Size(15, 14)
        Me.cbSecurity.TabIndex = 20
        Me.cbSecurity.UseVisualStyleBackColor = true
        '
        'cbGuard1
        '
        Me.cbGuard1.AutoSize = true
        Me.cbGuard1.Location = New System.Drawing.Point(191, 188)
        Me.cbGuard1.Name = "cbGuard1"
        Me.cbGuard1.Size = New System.Drawing.Size(15, 14)
        Me.cbGuard1.TabIndex = 21
        Me.cbGuard1.UseVisualStyleBackColor = true
        '
        'cbGuard2
        '
        Me.cbGuard2.AutoSize = true
        Me.cbGuard2.Location = New System.Drawing.Point(191, 201)
        Me.cbGuard2.Name = "cbGuard2"
        Me.cbGuard2.Size = New System.Drawing.Size(15, 14)
        Me.cbGuard2.TabIndex = 22
        Me.cbGuard2.UseVisualStyleBackColor = true
        '
        'lblStatLuck
        '
        Me.lblStatLuck.AutoSize = true
        Me.lblStatLuck.Location = New System.Drawing.Point(34, 237)
        Me.lblStatLuck.Name = "lblStatLuck"
        Me.lblStatLuck.Size = New System.Drawing.Size(34, 13)
        Me.lblStatLuck.TabIndex = 23
        Me.lblStatLuck.Text = "Luck:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Location = New System.Drawing.Point(118, 242)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 22)
        Me.Panel1.TabIndex = 24
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(1, 2)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 0
        '
        'tmrMessage
        '
        '
        'lblSkillCaptain
        '
        Me.lblSkillCaptain.Location = New System.Drawing.Point(118, 124)
        Me.lblSkillCaptain.Name = "lblSkillCaptain"
        Me.lblSkillCaptain.Size = New System.Drawing.Size(19, 13)
        Me.lblSkillCaptain.TabIndex = 25
        Me.lblSkillCaptain.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSkillScience
        '
        Me.lblSkillScience.Location = New System.Drawing.Point(118, 136)
        Me.lblSkillScience.Name = "lblSkillScience"
        Me.lblSkillScience.Size = New System.Drawing.Size(19, 13)
        Me.lblSkillScience.TabIndex = 26
        Me.lblSkillScience.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSkillMedical
        '
        Me.lblSkillMedical.Location = New System.Drawing.Point(118, 149)
        Me.lblSkillMedical.Name = "lblSkillMedical"
        Me.lblSkillMedical.Size = New System.Drawing.Size(19, 13)
        Me.lblSkillMedical.TabIndex = 27
        Me.lblSkillMedical.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSkillEngineer
        '
        Me.lblSkillEngineer.Location = New System.Drawing.Point(118, 162)
        Me.lblSkillEngineer.Name = "lblSkillEngineer"
        Me.lblSkillEngineer.Size = New System.Drawing.Size(19, 13)
        Me.lblSkillEngineer.TabIndex = 28
        Me.lblSkillEngineer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSkillSecurity
        '
        Me.lblSkillSecurity.Location = New System.Drawing.Point(118, 175)
        Me.lblSkillSecurity.Name = "lblSkillSecurity"
        Me.lblSkillSecurity.Size = New System.Drawing.Size(19, 13)
        Me.lblSkillSecurity.TabIndex = 29
        Me.lblSkillSecurity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSkillGuard1
        '
        Me.lblSkillGuard1.Location = New System.Drawing.Point(118, 188)
        Me.lblSkillGuard1.Name = "lblSkillGuard1"
        Me.lblSkillGuard1.Size = New System.Drawing.Size(19, 13)
        Me.lblSkillGuard1.TabIndex = 30
        Me.lblSkillGuard1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSkillGuard2
        '
        Me.lblSkillGuard2.Location = New System.Drawing.Point(118, 201)
        Me.lblSkillGuard2.Name = "lblSkillGuard2"
        Me.lblSkillGuard2.Size = New System.Drawing.Size(19, 13)
        Me.lblSkillGuard2.TabIndex = 31
        Me.lblSkillGuard2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStaminaCaptain
        '
        Me.lblStaminaCaptain.AutoSize = True
        Me.lblStaminaCaptain.Location = New System.Drawing.Point(160, 124)
        Me.lblStaminaCaptain.Name = "lblStaminaCaptain"
        Me.lblStaminaCaptain.Size = New System.Drawing.Size(0, 13)
        Me.lblStaminaCaptain.TabIndex = 32
        '
        'lblStaminaScience
        '
        Me.lblStaminaScience.AutoSize = True
        Me.lblStaminaScience.Location = New System.Drawing.Point(160, 136)
        Me.lblStaminaScience.Name = "lblStaminaScience"
        Me.lblStaminaScience.Size = New System.Drawing.Size(0, 13)
        Me.lblStaminaScience.TabIndex = 33
        '
        'lblStaminaMedical
        '
        Me.lblStaminaMedical.AutoSize = True
        Me.lblStaminaMedical.Location = New System.Drawing.Point(160, 149)
        Me.lblStaminaMedical.Name = "lblStaminaMedical"
        Me.lblStaminaMedical.Size = New System.Drawing.Size(0, 13)
        Me.lblStaminaMedical.TabIndex = 34
        '
        'lblStaminaEngineer
        '
        Me.lblStaminaEngineer.AutoSize = True
        Me.lblStaminaEngineer.Location = New System.Drawing.Point(160, 162)
        Me.lblStaminaEngineer.Name = "lblStaminaEngineer"
        Me.lblStaminaEngineer.Size = New System.Drawing.Size(0, 13)
        Me.lblStaminaEngineer.TabIndex = 35
        '
        'lblStaminaSecurity
        '
        Me.lblStaminaSecurity.AutoSize = True
        Me.lblStaminaSecurity.Location = New System.Drawing.Point(160, 175)
        Me.lblStaminaSecurity.Name = "lblStaminaSecurity"
        Me.lblStaminaSecurity.Size = New System.Drawing.Size(0, 13)
        Me.lblStaminaSecurity.TabIndex = 36
        '
        'lblStaminaGuard1
        '
        Me.lblStaminaGuard1.AutoSize = True
        Me.lblStaminaGuard1.Location = New System.Drawing.Point(160, 188)
        Me.lblStaminaGuard1.Name = "lblStaminaGuard1"
        Me.lblStaminaGuard1.Size = New System.Drawing.Size(0, 13)
        Me.lblStaminaGuard1.TabIndex = 37
        '
        'lblStaminaGuard2
        '
        Me.lblStaminaGuard2.AutoSize = True
        Me.lblStaminaGuard2.Location = New System.Drawing.Point(160, 201)
        Me.lblStaminaGuard2.Name = "lblStaminaGuard2"
        Me.lblStaminaGuard2.Size = New System.Drawing.Size(0, 13)
        Me.lblStaminaGuard2.TabIndex = 38
        '
        'lblLuck
        '
        Me.lblLuck.AutoSize = True
        Me.lblLuck.Location = New System.Drawing.Point(74, 237)
        Me.lblLuck.Name = "lblLuck"
        Me.lblLuck.Size = New System.Drawing.Size(0, 13)
        Me.lblLuck.TabIndex = 39
        '
        'btnNewBuild
        '
        Me.btnNewBuild.Location = New System.Drawing.Point(334, 10)
        Me.btnNewBuild.Name = "btnNewBuild"
        Me.btnNewBuild.Size = New System.Drawing.Size(75, 23)
        Me.btnNewBuild.TabIndex = 40
        Me.btnNewBuild.Text = "Restart"
        Me.btnNewBuild.UseVisualStyleBackColor = True
        '
        'btnAddEnemyShip
        '
        Me.btnAddEnemyShip.Location = New System.Drawing.Point(159, 49)
        Me.btnAddEnemyShip.Name = "btnAddEnemyShip"
        Me.btnAddEnemyShip.Size = New System.Drawing.Size(62, 49)
        Me.btnAddEnemyShip.TabIndex = 41
        Me.btnAddEnemyShip.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enemy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ship"
        Me.btnAddEnemyShip.UseVisualStyleBackColor = True
        '
        'btnFirePlayer
        '
        Me.btnFirePlayer.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnFirePlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirePlayer.Location = New System.Drawing.Point(354, 49)
        Me.btnFirePlayer.Name = "btnFirePlayer"
        Me.btnFirePlayer.Size = New System.Drawing.Size(62, 23)
        Me.btnFirePlayer.TabIndex = 42
        Me.btnFirePlayer.Text = "Player Fire"
        Me.btnFirePlayer.UseVisualStyleBackColor = False
        Me.btnFirePlayer.Visible = False
        '
        'btnFireEnemy
        '
        Me.btnFireEnemy.BackColor = System.Drawing.Color.Cornsilk
        Me.btnFireEnemy.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFireEnemy.Location = New System.Drawing.Point(354, 75)
        Me.btnFireEnemy.Name = "btnFireEnemy"
        Me.btnFireEnemy.Size = New System.Drawing.Size(62, 23)
        Me.btnFireEnemy.TabIndex = 43
        Me.btnFireEnemy.Text = "Enemy Fire"
        Me.btnFireEnemy.UseVisualStyleBackColor = False
        Me.btnFireEnemy.Visible = False
        '
        'btnIncrease
        '
        Me.btnIncrease.BackColor = System.Drawing.Color.LawnGreen
        Me.btnIncrease.Location = New System.Drawing.Point(1, 1)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(19, 19)
        Me.btnIncrease.TabIndex = 47
        Me.btnIncrease.Text = "+"
        Me.btnIncrease.UseVisualStyleBackColor = False
        '
        'btnDecrease
        '
        Me.btnDecrease.BackColor = System.Drawing.Color.OliveDrab
        Me.btnDecrease.Location = New System.Drawing.Point(22, 1)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(19, 19)
        Me.btnDecrease.TabIndex = 48
        Me.btnDecrease.Text = "-"
        Me.btnDecrease.UseVisualStyleBackColor = False
        '
        'pnlPlusMinus
        '
        Me.pnlPlusMinus.Controls.Add(Me.btnDecrease)
        Me.pnlPlusMinus.Controls.Add(Me.btnIncrease)
        Me.pnlPlusMinus.Location = New System.Drawing.Point(16, 104)
        Me.pnlPlusMinus.Name = "pnlPlusMinus"
        Me.pnlPlusMinus.Size = New System.Drawing.Size(42, 20)
        Me.pnlPlusMinus.TabIndex = 49
        Me.pnlPlusMinus.Visible = False
        '
        'lblOppStamina
        '
        Me.lblOppStamina.AutoSize = True
        Me.lblOppStamina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOppStamina.Location = New System.Drawing.Point(353, 111)
        Me.lblOppStamina.Name = "lblOppStamina"
        Me.lblOppStamina.Size = New System.Drawing.Size(45, 13)
        Me.lblOppStamina.TabIndex = 51
        Me.lblOppStamina.Text = "Stamina"
        '
        'lblOppSkill
        '
        Me.lblOppSkill.AutoSize = True
        Me.lblOppSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOppSkill.Location = New System.Drawing.Point(321, 111)
        Me.lblOppSkill.Name = "lblOppSkill"
        Me.lblOppSkill.Size = New System.Drawing.Size(26, 13)
        Me.lblOppSkill.TabIndex = 50
        Me.lblOppSkill.Text = "Skill"
        '
        'btnAddEnemyFighter
        '
        Me.btnAddEnemyFighter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEnemyFighter.Location = New System.Drawing.Point(268, 124)
        Me.btnAddEnemyFighter.Name = "btnAddEnemyFighter"
        Me.btnAddEnemyFighter.Size = New System.Drawing.Size(148, 21)
        Me.btnAddEnemyFighter.TabIndex = 52
        Me.btnAddEnemyFighter.Text = "Add Enemy Fighter"
        Me.btnAddEnemyFighter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Roll Dice"
        '
        'lblRoll1
        '
        Me.lblRoll1.AutoSize = True
        Me.lblRoll1.Location = New System.Drawing.Point(273, 225)
        Me.lblRoll1.Name = "lblRoll1"
        Me.lblRoll1.Size = New System.Drawing.Size(13, 13)
        Me.lblRoll1.TabIndex = 58
        Me.lblRoll1.Text = "1"
        '
        'lblRoll2
        '
        Me.lblRoll2.AutoSize = True
        Me.lblRoll2.Location = New System.Drawing.Point(289, 225)
        Me.lblRoll2.Name = "lblRoll2"
        Me.lblRoll2.Size = New System.Drawing.Size(13, 13)
        Me.lblRoll2.TabIndex = 59
        Me.lblRoll2.Text = "2"
        '
        'lblRoll3
        '
        Me.lblRoll3.AutoSize = True
        Me.lblRoll3.Location = New System.Drawing.Point(306, 225)
        Me.lblRoll3.Name = "lblRoll3"
        Me.lblRoll3.Size = New System.Drawing.Size(13, 13)
        Me.lblRoll3.TabIndex = 60
        Me.lblRoll3.Text = "3"
        '
        'btnFightPlayer
        '
        Me.btnFightPlayer.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnFightPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFightPlayer.Location = New System.Drawing.Point(268, 185)
        Me.btnFightPlayer.Name = "btnFightPlayer"
        Me.btnFightPlayer.Size = New System.Drawing.Size(72, 21)
        Me.btnFightPlayer.TabIndex = 63
        Me.btnFightPlayer.Text = "Player Fight"
        Me.btnFightPlayer.UseVisualStyleBackColor = False
        Me.btnFightPlayer.Visible = False
        '
        'btnFightEnemy
        '
        Me.btnFightEnemy.BackColor = System.Drawing.Color.Cornsilk
        Me.btnFightEnemy.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFightEnemy.Location = New System.Drawing.Point(344, 185)
        Me.btnFightEnemy.Name = "btnFightEnemy"
        Me.btnFightEnemy.Size = New System.Drawing.Size(72, 21)
        Me.btnFightEnemy.TabIndex = 64
        Me.btnFightEnemy.Text = "Enemy Fight"
        Me.btnFightEnemy.UseVisualStyleBackColor = false
        Me.btnFightEnemy.Visible = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 266)
        Me.Controls.Add(Me.btnFightEnemy)
        Me.Controls.Add(Me.btnFightPlayer)
        Me.Controls.Add(Me.lblRoll3)
        Me.Controls.Add(Me.lblRoll2)
        Me.Controls.Add(Me.lblRoll1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddEnemyFighter)
        Me.Controls.Add(Me.lblOppStamina)
        Me.Controls.Add(Me.lblOppSkill)
        Me.Controls.Add(Me.btnFireEnemy)
        Me.Controls.Add(Me.btnFirePlayer)
        Me.Controls.Add(Me.btnAddEnemyShip)
        Me.Controls.Add(Me.btnNewBuild)
        Me.Controls.Add(Me.lblLuck)
        Me.Controls.Add(Me.lblStaminaGuard2)
        Me.Controls.Add(Me.lblStaminaGuard1)
        Me.Controls.Add(Me.lblStaminaSecurity)
        Me.Controls.Add(Me.lblStaminaEngineer)
        Me.Controls.Add(Me.lblStaminaMedical)
        Me.Controls.Add(Me.lblStaminaScience)
        Me.Controls.Add(Me.lblStaminaCaptain)
        Me.Controls.Add(Me.lblSkillGuard2)
        Me.Controls.Add(Me.lblSkillGuard1)
        Me.Controls.Add(Me.lblSkillSecurity)
        Me.Controls.Add(Me.lblSkillEngineer)
        Me.Controls.Add(Me.lblSkillMedical)
        Me.Controls.Add(Me.lblSkillScience)
        Me.Controls.Add(Me.lblSkillCaptain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblStatLuck)
        Me.Controls.Add(Me.cbGuard2)
        Me.Controls.Add(Me.cbGuard1)
        Me.Controls.Add(Me.cbSecurity)
        Me.Controls.Add(Me.cbEngineer)
        Me.Controls.Add(Me.cbMedical)
        Me.Controls.Add(Me.cbScience)
        Me.Controls.Add(Me.cbCaptain)
        Me.Controls.Add(Me.lblStatStamina)
        Me.Controls.Add(Me.lblStatSkill)
        Me.Controls.Add(Me.lblCharGuard2)
        Me.Controls.Add(Me.lblCharGuard1)
        Me.Controls.Add(Me.lblCharSecurity)
        Me.Controls.Add(Me.lblCharEngineer)
        Me.Controls.Add(Me.lblCharMedical)
        Me.Controls.Add(Me.lblCharScience)
        Me.Controls.Add(Me.lblCharCaptain)
        Me.Controls.Add(Me.lblShieldsPlayer)
        Me.Controls.Add(Me.lblWeaponsPlayer)
        Me.Controls.Add(Me.lblCharShip)
        Me.Controls.Add(Me.lblStatShields)
        Me.Controls.Add(Me.lblStatWeapons)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tbVersion)
        Me.Controls.Add(Me.pnlPlusMinus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.pnlPlusMinus.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tbVersion As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblStatWeapons As System.Windows.Forms.Label
    Friend WithEvents lblStatShields As System.Windows.Forms.Label
    Friend WithEvents lblCharShip As System.Windows.Forms.Label
    Friend WithEvents lblWeaponsPlayer As System.Windows.Forms.Label
    Friend WithEvents lblShieldsPlayer As System.Windows.Forms.Label
    Friend WithEvents lblCharCaptain As System.Windows.Forms.Label
    Friend WithEvents lblCharScience As System.Windows.Forms.Label
    Friend WithEvents lblCharMedical As System.Windows.Forms.Label
    Friend WithEvents lblCharEngineer As System.Windows.Forms.Label
    Friend WithEvents lblCharSecurity As System.Windows.Forms.Label
    Friend WithEvents lblCharGuard1 As System.Windows.Forms.Label
    Friend WithEvents lblCharGuard2 As System.Windows.Forms.Label
    Friend WithEvents lblStatSkill As System.Windows.Forms.Label
    Friend WithEvents lblStatStamina As System.Windows.Forms.Label
    Friend WithEvents cbCaptain As System.Windows.Forms.CheckBox
    Friend WithEvents cbScience As System.Windows.Forms.CheckBox
    Friend WithEvents cbMedical As System.Windows.Forms.CheckBox
    Friend WithEvents cbEngineer As System.Windows.Forms.CheckBox
    Friend WithEvents cbSecurity As System.Windows.Forms.CheckBox
    Friend WithEvents cbGuard1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbGuard2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblStatLuck As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents tmrMessage As System.Windows.Forms.Timer
    Friend WithEvents lblSkillCaptain As System.Windows.Forms.Label
    Friend WithEvents lblSkillScience As System.Windows.Forms.Label
    Friend WithEvents lblSkillMedical As System.Windows.Forms.Label
    Friend WithEvents lblSkillEngineer As System.Windows.Forms.Label
    Friend WithEvents lblSkillSecurity As System.Windows.Forms.Label
    Friend WithEvents lblSkillGuard1 As System.Windows.Forms.Label
    Friend WithEvents lblSkillGuard2 As System.Windows.Forms.Label
    Friend WithEvents lblStaminaCaptain As System.Windows.Forms.Label
    Friend WithEvents lblStaminaScience As System.Windows.Forms.Label
    Friend WithEvents lblStaminaMedical As System.Windows.Forms.Label
    Friend WithEvents lblStaminaEngineer As System.Windows.Forms.Label
    Friend WithEvents lblStaminaSecurity As System.Windows.Forms.Label
    Friend WithEvents lblStaminaGuard1 As System.Windows.Forms.Label
    Friend WithEvents lblStaminaGuard2 As System.Windows.Forms.Label
    Friend WithEvents lblLuck As System.Windows.Forms.Label
    Friend WithEvents btnNewBuild As System.Windows.Forms.Button
    Friend WithEvents btnAddEnemyShip As System.Windows.Forms.Button
    Friend WithEvents btnFirePlayer As System.Windows.Forms.Button
    Friend WithEvents btnFireEnemy As System.Windows.Forms.Button
    Friend WithEvents btnIncrease As System.Windows.Forms.Button
    Friend WithEvents btnDecrease As System.Windows.Forms.Button
    Friend WithEvents pnlPlusMinus As System.Windows.Forms.Panel
    Friend WithEvents lblOppStamina As System.Windows.Forms.Label
    Friend WithEvents lblOppSkill As System.Windows.Forms.Label
    Friend WithEvents btnAddEnemyFighter As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRoll1 As System.Windows.Forms.Label
    Friend WithEvents lblRoll2 As System.Windows.Forms.Label
    Friend WithEvents lblRoll3 As System.Windows.Forms.Label
    Friend WithEvents btnFightPlayer As System.Windows.Forms.Button
    Friend WithEvents btnFightEnemy As System.Windows.Forms.Button

End Class
