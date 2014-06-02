Public Class EnemyFighter
    Private nSkill As UInteger
    Private nStamina As UInteger

    Private gBox As New System.Windows.Forms.GroupBox
    Private lblTitle As New System.Windows.Forms.Label
    Private lblSkill As New System.Windows.Forms.Label
    Private lblStamina As New System.Windows.Forms.Label
    Private btnCancel As New System.Windows.Forms.Button


    'Constructor
    Public Sub New(ByRef button As System.Windows.Forms.Button, ByVal count As Integer)
        Do
            UInteger.TryParse(InputBox("Enemy skill?"), nSkill)
            If nSkill = 0 Then
                Form1.msgDisplay("Enemy skill must be a positive integer.", 3)
            End If
        Loop While nSkill = 0
        Do
            UInteger.TryParse(InputBox("Enemy skill: " & nSkill & vbCrLf & "Enemy stamina?"), nStamina)
            If nStamina = 0 Then
                Form1.msgDisplay("Enemy stamina must be a positive integer.", 3)
            End If
        Loop While nStamina = 0

        gBox.Location = New Point(button.Location.X, button.Location.Y - 6)
        gBox.Size = New Size(button.Size.Width, button.Size.Height + 6)

        lblTitle.Text = "Fighter " & count + 1 & ":"
        lblTitle.Location = New Point(1, 9)
        lblTitle.AutoSize = True
        AddHandler lblTitle.Click, AddressOf TargetMe
        gBox.Controls.Add(lblTitle)

        lblSkill.Text = CStr(nSkill)
        lblSkill.Location = New Point(60, 9)
        lblSkill.Size = New Size(19, 13)
        gBox.Controls.Add(lblSkill)

        lblStamina.Text = CStr(nStamina)
        lblStamina.Location = New Point(98, 9)
        lblStamina.Size = New Size(19, 13)
        lblStamina.TextAlign = ContentAlignment.TopRight
        gBox.Controls.Add(lblStamina)

        btnCancel.Text = "X"
        btnCancel.Location = New Point(128, 7)
        btnCancel.Size = New Size(18, 18)
        btnCancel.TextAlign = ContentAlignment.MiddleCenter
        btnCancel.BackColor = Color.Red
        AddHandler btnCancel.Click, AddressOf RemoveMe
        gBox.Controls.Add(btnCancel)
    End Sub


    'Accessors
    ReadOnly Property Skill As UInteger
        Get
            Return nSkill
        End Get
    End Property

    ReadOnly Property Stamina As UInteger
        Get
            Return nStamina
        End Get
    End Property

    ReadOnly Property InfoBox As System.Windows.Forms.GroupBox
        Get
            Return gBox
        End Get
    End Property


    'Mutators
    Private Sub TargetMe()
        Form1.TargetFighter(Me)
    End Sub

    Public Sub DoDamage(ByVal dmg As Integer)
        Form1.msgDisplay("'EnemyFighter.DoDamage' needs code.", 3)
    End Sub

    Public Sub Kill()
        RemoveMe()
    End Sub


    'Cleanup
    Private Sub RemoveMe()
        Form1.RemoveEnemyFighter(Me)
    End Sub
End Class
