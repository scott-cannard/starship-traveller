Public Class Form1
    Private rand As New Random()

    Private ship As Traveller
    Private lNmeShips As New List(Of EnemyShip)
    Private lNmeFighters As New List(Of EnemyFighter)

    Private dice As New Dice(rand)
    Private qMessage As New List(Of String)
    Private qMark As New List(Of Integer)
    Private ctrMessage As Integer = 0

    Public ftRegular As New Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    Public ftUnderline As New Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Underline)
    Public ftBold As New Drawing.Font("Microsoft Sans Serif", 6.5, FontStyle.Bold)
    Public ftBoldUnderline As New Drawing.Font("Microsoft Sans Serif", 6.5, FontStyle.Bold Or FontStyle.Underline)


    'Load Form
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Controls.Add(dice.InfoBox)
        Initialize(sender)
        msgDisplay("Fix Form-loader/Restart ASAP!", 5)
    End Sub

    Private Sub Initialize(ByRef sender As System.Object)
        'Read disk-stored version #
        Dim reader As New IO.StreamReader("vn.dat")
        Dim nVersion As Integer
        If Not Integer.TryParse(reader.ReadLine, nVersion) Then
            nVersion = 0
        End If
        reader.Close()

        'Build ship
        ship = New Traveller(rand)

        'Update UI
        UpdateStatDisplay()
        dice.Reset(rand)

        'Increment & write version #
        nVersion += 1
        tbVersion.Text = nVersion
        tbVersion_KeyUp(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
        Dim writer As New IO.StreamWriter("vn.dat")
        writer.WriteLine(nVersion)
        writer.Close()
    End Sub

    'Version Control
    Private Sub tbVersion_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tbVersion.KeyUp
        tbVersion.Size = New Point(tbVersion.TextLength * 6 + 12, 20)
        If e.KeyCode = Keys.Enter Then
            lblTitle.Focus()
        End If
    End Sub

    Private Sub tbVersion_Unfocus(sender As System.Object, e As System.EventArgs) Handles tbVersion.LostFocus
        Dim writer As IO.StreamWriter
        Dim reader As IO.StreamReader
        Dim validata As Integer

        If Integer.TryParse(tbVersion.Text, validata) Then
            writer = New IO.StreamWriter("vn.dat")
            writer.WriteLine(validata)
            writer.Close()
        Else
            msgDisplay("Build# must be an integer value.", 3)
            reader = New IO.StreamReader("vn.dat")
            If Not Integer.TryParse(reader.ReadLine, validata) Then
                validata = 0
            End If
            reader.Close()
            tbVersion.Text = validata
            tbVersion_KeyUp(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
        End If
    End Sub


    'Mission Checkboxes
    Private Sub checkBoxChange(ByRef box As CheckBox)
        If box.Checked Then
            box.Text = "On Mission"
        Else
            box.Text = ""
        End If
    End Sub

    Private Sub cbCaptain_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbCaptain.CheckedChanged
        checkBoxChange(cbCaptain)
    End Sub

    Private Sub cbScience_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbScience.CheckedChanged
        checkBoxChange(cbScience)
    End Sub

    Private Sub cbMedical_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbMedical.CheckedChanged
        checkBoxChange(cbMedical)
    End Sub

    Private Sub cbEngineer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbEngineer.CheckedChanged
        checkBoxChange(cbEngineer)
    End Sub

    Private Sub cbSecurity_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbSecurity.CheckedChanged
        checkBoxChange(cbSecurity)
    End Sub

    Private Sub cbGuard1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbGuard1.CheckedChanged
        checkBoxChange(cbGuard1)
    End Sub

    Private Sub cbGuard2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbGuard2.CheckedChanged
        checkBoxChange(cbGuard2)
    End Sub


    'Message Management
    Public Sub msgDisplay(ByVal msg As String, ByVal sec As Single)
        qMessage.Add(msg)
        qMark.Add(sec * 1000 / tmrMessage.Interval)
        tmrMessage.Start()
        If qMessage.Count = 1 Then
            lblMessage.Text = msg
            ctrMessage = sec * 1000 / tmrMessage.Interval
        End If
    End Sub

    Private Sub tmrMessage_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMessage.Tick
        ctrMessage -= 1
        If ctrMessage <= 0 Then
            qMessage.RemoveAt(0)
            qMark.RemoveAt(0)
            If qMessage.Count > 0 Then
                lblMessage.Text = qMessage(0)
                ctrMessage = qMark(0)
            Else
                lblMessage.Text = ""
                tmrMessage.Stop()
            End If
        End If
    End Sub


    'Stat Selection Labels
    Private Sub lblCharShip_Click(sender As System.Object, e As System.EventArgs) Handles lblCharShip.Click
        lblCharShip.Font = ftBoldUnderline

        'lblStatWeapons
        'lblStatShields

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        lblStatSkill.Font = ftUnderline
        lblStatStamina.Font = ftUnderline

        lblStatLuck.Font = ftRegular

        If lblStatWeapons.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.Weapons
            pnlPlusMinus.Show()
        ElseIf lblStatShields.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.Shields
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
            msgDisplay("Select a ship stat.", 2)
        End If
    End Sub


    Private Sub lblStatWeapons_Click(sender As System.Object, e As System.EventArgs) Handles lblStatWeapons.Click
        lblCharShip.Font = ftBoldUnderline

        lblStatWeapons.Font = ftBold
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        lblStatSkill.Font = ftUnderline
        lblStatStamina.Font = ftUnderline

        lblStatLuck.Font = ftRegular

        ship.TargetStat = Traveller.Stat.Weapons
        pnlPlusMinus.Show()
    End Sub

    Private Sub lblStatShields_Click(sender As System.Object, e As System.EventArgs) Handles lblStatShields.Click
        lblCharShip.Font = ftBoldUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftBold

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        lblStatSkill.Font = ftUnderline
        lblStatStamina.Font = ftUnderline

        lblStatLuck.Font = ftRegular

        ship.TargetStat = Traveller.Stat.Shields
        pnlPlusMinus.Show()
    End Sub


    Private Sub lblWeaponsPlayer_Click(sender As System.Object, e As System.EventArgs) Handles lblWeaponsPlayer.Click
        lblStatWeapons_Click(sender, e)
    End Sub

    Private Sub lblShieldsPlayer_Click(sender As System.Object, e As System.EventArgs) Handles lblShieldsPlayer.Click
        lblStatShields_Click(sender, e)
    End Sub


    Private Sub lblCharCaptain_Click(sender As System.Object, e As System.EventArgs) Handles lblCharCaptain.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftBold
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        'lblStatSkill
        'lblStatStamina

        lblStatLuck.Font = ftRegular

        If lblStatSkill.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.CaptainSkill
            pnlPlusMinus.Show()
        ElseIf lblStatStamina.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.CaptainStamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
        End If
    End Sub

    Private Sub lblCharScience_Click(sender As System.Object, e As System.EventArgs) Handles lblCharScience.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftBold
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        'lblStatSkill
        'lblStatStamina

        lblStatLuck.Font = ftRegular

        If lblStatSkill.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.ScienceSkill
            pnlPlusMinus.Show()
        ElseIf lblStatStamina.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.ScienceStamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
        End If
    End Sub

    Private Sub lblCharMedical_Click(sender As System.Object, e As System.EventArgs) Handles lblCharMedical.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftBold
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        'lblStatSkill
        'lblStatStamina

        lblStatLuck.Font = ftRegular

        If lblStatSkill.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.MedicalSkill
            pnlPlusMinus.Show()
        ElseIf lblStatStamina.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.MedicalStamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
        End If
    End Sub

    Private Sub lblCharEngineer_Click(sender As System.Object, e As System.EventArgs) Handles lblCharEngineer.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftBold
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        'lblStatSkill
        'lblStatStamina

        lblStatLuck.Font = ftRegular

        If lblStatSkill.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.EngineerSkill
            pnlPlusMinus.Show()
        ElseIf lblStatStamina.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.EngineerStamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
        End If
    End Sub

    Private Sub lblCharSecurity_Click(sender As System.Object, e As System.EventArgs) Handles lblCharSecurity.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftBold
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        'lblStatSkill
        'lblStatStamina

        lblStatLuck.Font = ftRegular

        If lblStatSkill.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.SecuritySkill
            pnlPlusMinus.Show()
        ElseIf lblStatStamina.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.SecurityStamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
        End If
    End Sub

    Private Sub lblCharGuard1_Click(sender As System.Object, e As System.EventArgs) Handles lblCharGuard1.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftBold
        lblCharGuard2.Font = ftRegular

        'lblStatSkill
        'lblStatStamina

        lblStatLuck.Font = ftRegular

        If lblStatSkill.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.Guard1Skill
            pnlPlusMinus.Show()
        ElseIf lblStatStamina.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.Guard1Stamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
        End If
    End Sub

    Private Sub lblCharGuard2_Click(sender As System.Object, e As System.EventArgs) Handles lblCharGuard2.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftBold

        'lblStatSkill
        'lblStatStamina

        lblStatLuck.Font = ftRegular

        If lblStatSkill.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.Guard2Skill
            pnlPlusMinus.Show()
        ElseIf lblStatStamina.Font.Equals(ftBoldUnderline) Then
            ship.TargetStat = Traveller.Stat.Guard2Stamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
        End If
    End Sub


    Private Sub lblStatSkill_Click(sender As System.Object, e As System.EventArgs) Handles lblStatSkill.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        'lblCharCaptain
        'lblCharScience
        'lblCharMedical
        'lblCharEngineer
        'lblCharSecurity
        'lblCharGuard1
        'lblCharGuard2

        lblStatSkill.Font = ftBoldUnderline
        lblStatStamina.Font = ftUnderline

        lblStatLuck.Font = ftRegular

        If lblCharCaptain.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.CaptainSkill
            pnlPlusMinus.Show()
        ElseIf lblCharScience.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.ScienceSkill
            pnlPlusMinus.Show()
        ElseIf lblCharMedical.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.MedicalSkill
            pnlPlusMinus.Show()
        ElseIf lblCharEngineer.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.EngineerSkill
            pnlPlusMinus.Show()
        ElseIf lblCharSecurity.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.SecuritySkill
            pnlPlusMinus.Show()
        ElseIf lblCharGuard1.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.Guard1Skill
            pnlPlusMinus.Show()
        ElseIf lblCharGuard2.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.Guard2Skill
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
            msgDisplay("Select an officer.", 2)
        End If
    End Sub

    Private Sub lblStatStamina_Click(sender As System.Object, e As System.EventArgs) Handles lblStatStamina.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        'lblCharCaptain
        'lblCharScience
        'lblCharMedical
        'lblCharEngineer
        'lblCharSecurity
        'lblCharGuard1
        'lblCharGuard2

        lblStatSkill.Font = ftUnderline
        lblStatStamina.Font = ftBoldUnderline

        lblStatLuck.Font = ftRegular

        If lblCharCaptain.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.CaptainStamina
            pnlPlusMinus.Show()
        ElseIf lblCharScience.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.ScienceStamina
            pnlPlusMinus.Show()
        ElseIf lblCharMedical.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.MedicalStamina
            pnlPlusMinus.Show()
        ElseIf lblCharEngineer.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.EngineerStamina
            pnlPlusMinus.Show()
        ElseIf lblCharSecurity.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.SecurityStamina
            pnlPlusMinus.Show()
        ElseIf lblCharGuard1.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.Guard1Stamina
            pnlPlusMinus.Show()
        ElseIf lblCharGuard2.Font.Equals(ftBold) Then
            ship.TargetStat = Traveller.Stat.Guard2Stamina
            pnlPlusMinus.Show()
        Else
            ship.TargetStat = Traveller.Stat.Disable
            pnlPlusMinus.Hide()
            msgDisplay("Select an officer.", 2)
        End If
    End Sub


    Private Sub lblSkillCaptain_Click(sender As System.Object, e As System.EventArgs) Handles lblSkillCaptain.Click
        lblCharCaptain_Click(sender, e)
        lblStatSkill_Click(sender, e)
    End Sub

    Private Sub lblSkillScience_Click(sender As System.Object, e As System.EventArgs) Handles lblSkillScience.Click
        lblCharScience_Click(sender, e)
        lblStatSkill_Click(sender, e)
    End Sub

    Private Sub lblSkillMedical_Click(sender As System.Object, e As System.EventArgs) Handles lblSkillMedical.Click
        lblCharMedical_Click(sender, e)
        lblStatSkill_Click(sender, e)
    End Sub

    Private Sub lblSkillEngineer_Click(sender As System.Object, e As System.EventArgs) Handles lblSkillEngineer.Click
        lblCharEngineer_Click(sender, e)
        lblStatSkill_Click(sender, e)
    End Sub

    Private Sub lblSkillSecurity_Click(sender As System.Object, e As System.EventArgs) Handles lblSkillSecurity.Click
        lblCharSecurity_Click(sender, e)
        lblStatSkill_Click(sender, e)
    End Sub

    Private Sub lblSkillGuard1_Click(sender As System.Object, e As System.EventArgs) Handles lblSkillGuard1.Click
        lblCharGuard1_Click(sender, e)
        lblStatSkill_Click(sender, e)
    End Sub

    Private Sub lblSkillGuard2_Click(sender As System.Object, e As System.EventArgs) Handles lblSkillGuard2.Click
        lblCharGuard2_Click(sender, e)
        lblStatSkill_Click(sender, e)
    End Sub

    Private Sub lblStaminaCaptain_Click(sender As System.Object, e As System.EventArgs) Handles lblStaminaCaptain.Click
        lblCharCaptain_Click(sender, e)
        lblStatStamina_Click(sender, e)
    End Sub

    Private Sub lblStaminaScience_Click(sender As System.Object, e As System.EventArgs) Handles lblStaminaScience.Click
        lblCharScience_Click(sender, e)
        lblStatStamina_Click(sender, e)
    End Sub

    Private Sub lblStaminaMedical_Click(sender As System.Object, e As System.EventArgs) Handles lblStaminaMedical.Click
        lblCharMedical_Click(sender, e)
        lblStatStamina_Click(sender, e)
    End Sub

    Private Sub lblStaminaEngineer_Click(sender As System.Object, e As System.EventArgs) Handles lblStaminaEngineer.Click
        lblCharEngineer_Click(sender, e)
        lblStatStamina_Click(sender, e)
    End Sub

    Private Sub lblStaminaSecurity_Click(sender As System.Object, e As System.EventArgs) Handles lblStaminaSecurity.Click
        lblCharSecurity_Click(sender, e)
        lblStatStamina_Click(sender, e)
    End Sub

    Private Sub lblStaminaGuard1_Click(sender As System.Object, e As System.EventArgs) Handles lblStaminaGuard1.Click
        lblCharGuard1_Click(sender, e)
        lblStatStamina_Click(sender, e)
    End Sub

    Private Sub lblStaminaGuard2_Click(sender As System.Object, e As System.EventArgs) Handles lblStaminaGuard2.Click
        lblCharGuard2_Click(sender, e)
        lblStatStamina_Click(sender, e)
    End Sub


    Private Sub lblStatLuck_Click(sender As System.Object, e As System.EventArgs) Handles lblStatLuck.Click
        lblCharShip.Font = ftUnderline

        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular

        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular

        lblStatSkill.Font = ftUnderline
        lblStatStamina.Font = ftUnderline

        lblStatLuck.Font = ftBold

        ship.TargetStat = Traveller.Stat.Luck
        pnlPlusMinus.Show()
    End Sub

    Private Sub lblLuck_Click(sender As System.Object, e As System.EventArgs) Handles lblLuck.Click
        lblStatLuck_Click(sender, e)
    End Sub


    'Buttons: Ship
    Private Sub btnRebuild_Click(sender As System.Object, e As System.EventArgs) Handles btnNewBuild.Click
        Initialize(sender)

        lblCharShip.Font = ftUnderline
        lblStatWeapons.Font = ftRegular
        lblStatShields.Font = ftRegular
        lblCharCaptain.Font = ftRegular
        lblCharScience.Font = ftRegular
        lblCharMedical.Font = ftRegular
        lblCharEngineer.Font = ftRegular
        lblCharSecurity.Font = ftRegular
        lblCharGuard1.Font = ftRegular
        lblCharGuard2.Font = ftRegular
        lblStatSkill.Font = ftUnderline
        lblStatStamina.Font = ftUnderline
        lblStatLuck.Font = ftRegular

        pnlPlusMinus.Hide()

        cbCaptain.Checked = False
        cbScience.Checked = False
        cbMedical.Checked = False
        cbEngineer.Checked = False
        cbSecurity.Checked = False
        cbGuard1.Checked = False
        cbGuard2.Checked = False


    End Sub

    Private Sub btnIncrease_Click(sender As System.Object, e As System.EventArgs) Handles btnIncrease.Click
        ship.IncrementStat()
        UpdateStatDisplay()
    End Sub

    Private Sub btnDecrease_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrease.Click
        ship.DecrementStat()
        UpdateStatDisplay()
    End Sub

    'Buttons: Enemy
    Private Sub btnAddEnemyShip_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEnemyShip.Click
        Dim nme As New EnemyShip(btnAddEnemyShip, lNmeShips.Count)
        lNmeShips.Add(nme)
        btnAddEnemyShip.Location = New Point(btnAddEnemyShip.Location.X + 65, btnAddEnemyShip.Location.Y)
        Me.Controls.Add(nme.InfoBox)

        If lNmeShips.Count = 3 Then
            btnAddEnemyShip.Hide()
        End If
        btnFirePlayer.Show()
        btnFireEnemy.Show()
    End Sub

    Private Sub btnAddEnemyFighter_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEnemyFighter.Click
        Dim nme As New EnemyFighter(btnAddEnemyFighter, lNmeFighters.Count)
        lNmeFighters.Add(nme)
        btnAddEnemyFighter.Location = New Point(btnAddEnemyFighter.Location.X, btnAddEnemyFighter.Location.Y + 20)
        Me.Controls.Add(nme.InfoBox)

        If lNmeFighters.Count = 3 Then
            btnAddEnemyFighter.Hide()
        End If
        btnFightPlayer.Show()
        btnFightEnemy.Show()
    End Sub

    'Buttons: Dice
    Private Sub lblRoll1_Click(sender As System.Object, e As System.EventArgs) Handles lblRoll1.Click
        dice.Roll(1, rand)
    End Sub

    Private Sub lblRoll2_Click(sender As System.Object, e As System.EventArgs) Handles lblRoll2.Click
        dice.Roll(2, rand)
    End Sub

    Private Sub lblRoll3_Click(sender As System.Object, e As System.EventArgs) Handles lblRoll3.Click
        dice.Roll(3, rand)
    End Sub


    'Combat
    Public Sub TargetShip(ByRef tgt As EnemyShip)
        For Each nme As EnemyShip In lNmeShips
            If lNmeShips.IndexOf(nme) = lNmeShips.IndexOf(tgt) Then
                nme.InfoBox.Controls(0).Font = ftBold
            Else
                nme.InfoBox.Controls(0).Font = ftRegular
            End If
        Next
    End Sub

    Private Sub btnFirePlayer_Click(sender As System.Object, e As System.EventArgs) Handles btnFirePlayer.Click
        Dim weaponRoll As Integer = rand.Next(1, 7) + rand.Next(1, 7)
        Dim shieldRoll As Integer
        Dim defense As Integer = lNmeShips(0).ShieldStrength
        Dim damage As UInteger = 0

        If weaponRoll >= CInt(lblWeaponsPlayer.Text) Then
            msgDisplay("Attack: " & weaponRoll & " >= " & CInt(lblWeaponsPlayer.Text) & " ... Player misses.", 2)
        Else
            shieldRoll = rand.Next(1, 7) + rand.Next(1, 7)
            Select Case shieldRoll
                Case 12
                    damage = 6
                Case defense To 11
                    damage = 4
                Case Else
                    damage = 2
            End Select

            If Not lNmeShips(0).DoDamage(damage) Then
                msgDisplay("Attack: " & weaponRoll & " < " & CInt(lblWeaponsPlayer.Text) & " ... HIT, " & _
                           "Power: " & shieldRoll & " / " & defense & " ... Enemy takes " & damage & " damage!", 2)
            Else
                msgDisplay("Attack: " & weaponRoll & " < " & CInt(lblWeaponsPlayer.Text) & " ... HIT, " & _
                           "Power: " & shieldRoll & " / " & defense & " ... Enemy Destroyed!!", 2)
            End If
        End If
    End Sub

    Private Sub btnFireEnemy_Click(sender As System.Object, e As System.EventArgs) Handles btnFireEnemy.Click
        Dim weaponRoll As Integer = rand.Next(1, 7) + rand.Next(1, 7)
        Dim shieldRoll As Integer
        Dim defense As Integer = CInt(lblShieldsPlayer.Text)
        Dim damage As UInteger = 0

        For Each nme As EnemyShip In lNmeShips
            If weaponRoll >= nme.WeaponStrength Then
                'enemy missed
                msgDisplay("Attack: " & weaponRoll & " >= " & nme.WeaponStrength & " ... Enemy misses.", 1)
            Else
                'enemy hit...calculate damage
                shieldRoll = rand.Next(1, 7) + rand.Next(1, 7)
                Select Case shieldRoll
                    Case 12
                        damage = 6
                    Case defense To 11
                        damage = 4
                    Case Else
                        damage = 2
                End Select

                If Not ship.TakeDamage(damage) Then
                    'ship survived
                    UpdateStatDisplay()
                    msgDisplay("Attack: " & weaponRoll & " < " & nme.WeaponStrength & " ... HIT, " & _
                               "Power: " & shieldRoll & " / " & defense & " ... You take " & damage & " damage!", 1)
                Else
                    'ship destroyed
                    msgDisplay("Attack: " & weaponRoll & " < " & nme.WeaponStrength & " ... HIT, " & _
                               "Power: " & shieldRoll & " / " & defense & " ... Ship Destroyed!!", 1)
                    GameOver()
                    Return
                End If
            End If
        Next
    End Sub

    Public Sub TargetFighter(ByRef tgt As EnemyFighter)
        For Each nme As EnemyFighter In lNmeFighters
            If lNmeFighters.IndexOf(nme) = lNmeFighters.IndexOf(tgt) Then
                nme.InfoBox.Controls(0).Font = ftBold
            Else
                nme.InfoBox.Controls(0).Font = ftRegular
            End If
        Next
    End Sub

    Private Sub btnFightPlayer_Click(sender As System.Object, e As System.EventArgs) Handles btnFightPlayer.Click
        msgDisplay("'Form1.btnFightPlayer_Click' needs code.", 3)
    End Sub

    Private Sub btnFightEnemy_Click(sender As System.Object, e As System.EventArgs) Handles btnFightEnemy.Click
        msgDisplay("'Form1.btnFightEnemy_Click' needs code.", 3)
    End Sub


    'Cleanup
    Private Sub UpdateStatDisplay()
        lblWeaponsPlayer.Text = ship.Weapons
        lblShieldsPlayer.Text = ship.Shields
        lblSkillCaptain.Text = ship.CaptainSkill
        lblSkillScience.Text = ship.ScienceSkill
        lblSkillMedical.Text = ship.MedicalSkill
        lblSkillEngineer.Text = ship.EngineerSkill
        lblSkillSecurity.Text = ship.SecuritySkill
        lblSkillGuard1.Text = ship.Guard1Skill
        lblSkillGuard2.Text = ship.Guard2Skill
        lblStaminaCaptain.Text = ship.CaptainStamina
        lblStaminaScience.Text = ship.ScienceStamina
        lblStaminaMedical.Text = ship.MedicalStamina
        lblStaminaEngineer.Text = ship.EngineerStamina
        lblStaminaSecurity.Text = ship.SecurityStamina
        lblStaminaGuard1.Text = ship.Guard1Stamina
        lblStaminaGuard2.Text = ship.Guard2Stamina
        lblLuck.Text = ship.Luck
    End Sub

    Public Sub RemoveEnemyShip(ByRef nme As EnemyShip)
        lNmeShips.Remove(nme)
        Me.Controls.Remove(nme.InfoBox)
        btnAddEnemyShip.Location = New Point(btnAddEnemyShip.Location.X - 65, btnAddEnemyShip.Location.Y)
        For Each ship As EnemyShip In lNmeShips
            ship.InfoBox.Location = New Point(btnAddEnemyShip.Location.X - (lNmeShips.Count - lNmeShips.IndexOf(ship)) * 65, _
                                              btnAddEnemyShip.Location.Y - 6)
        Next
        btnAddEnemyShip.Show()
        If lNmeShips.Count = 0 Then
            btnFirePlayer.Hide()
            btnFireEnemy.Hide()
        End If
    End Sub

    Public Sub RemoveEnemyFighter(ByRef nme As EnemyFighter)
        lNmeFighters.Remove(nme)
        Me.Controls.Remove(nme.InfoBox)
        btnAddEnemyFighter.Location = New Point(btnAddEnemyFighter.Location.X, btnAddEnemyFighter.Location.Y - 20)
        For Each fighter As EnemyFighter In lNmeFighters
            fighter.InfoBox.Location = New Point(btnAddEnemyFighter.Location.X, _
                                                 btnAddEnemyFighter.Location.Y - (lNmeFighters.Count - lNmeFighters.IndexOf(fighter)) * 20 - 6)
        Next
        btnAddEnemyFighter.Show()
        If lNmeFighters.Count = 0 Then
            btnFightPlayer.Hide()
            btnFightEnemy.Hide()
        End If
    End Sub

    Private Sub GameOver()
        MessageBox.Show("Game Over")
        For d = 0 To lNmeShips.Count - 1
            lNmeShips(0).Kill()
        Next

        btnRebuild_Click(New System.Object, New System.EventArgs)
    End Sub
End Class
