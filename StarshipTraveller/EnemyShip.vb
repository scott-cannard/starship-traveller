Public Class EnemyShip
    Private nWeapons As UInteger = 0
    Private nShields As UInteger = 0

    Private gBox As New System.Windows.Forms.GroupBox
    Private lblTitle As New System.Windows.Forms.Label
    Private lblWeapons As New System.Windows.Forms.Label
    Private lblShields As New System.Windows.Forms.Label
    Private btnCancel As New System.Windows.Forms.Button


    'Constructor
    Public Sub New(ByRef button As System.Windows.Forms.Button, ByVal count As Integer)
        Do
            UInteger.TryParse(InputBox("Enemy weapon strength?"), nWeapons)
            If nWeapons = 0 Then
                Form1.msgDisplay("Enemy weapon strength must be a positive integer.", 3)
            End If
        Loop While nWeapons = 0
        Do
            UInteger.TryParse(InputBox("Enemy weapon strength: " & nWeapons & vbCrLf & "Enemy shield strength?"), nShields)
            If nShields = 0 Then
                Form1.msgDisplay("Enemy shield strength must be a positive integer.", 3)
            End If
        Loop While nShields = 0

        gBox.Location = New Point(button.Location.X, button.Location.Y - 6)
        gBox.Size = New Size(button.Size.Width, button.Size.Height + 6)

        lblTitle.Text = "Enemy #" & count + 1
        lblTitle.Location = New Point(1, 8)
        lblTitle.Size = New Size(gBox.Size.Width - 2, 13)
        lblTitle.TextAlign = ContentAlignment.TopCenter
        AddHandler lblTitle.Click, AddressOf TargetMe
        gBox.Controls.Add(lblTitle)

        lblWeapons.Text = CStr(nWeapons)
        lblWeapons.Location = New Point(11, 24)
        lblWeapons.Size = New Size(19, 13)
        lblWeapons.TextAlign = ContentAlignment.TopRight
        gBox.Controls.Add(lblWeapons)

        lblShields.Text = CStr(nShields)
        lblShields.Location = New Point(11, 40)
        lblShields.Size = New Size(19, 13)
        lblShields.TextAlign = ContentAlignment.TopRight
        gBox.Controls.Add(lblShields)

        btnCancel.Text = "X"
        btnCancel.Location = New Point(37, 26)
        btnCancel.Size = New Size(21, 23)
        btnCancel.TextAlign = ContentAlignment.MiddleCenter
        btnCancel.BackColor = Color.Red
        AddHandler btnCancel.Click, AddressOf RemoveMe
        gBox.Controls.Add(btnCancel)
    End Sub


    'Accessors
    ReadOnly Property WeaponStrength As UInteger
        Get
            Return nWeapons
        End Get
    End Property

    ReadOnly Property ShieldStrength As UInteger
        Get
            Return nShields
        End Get
    End Property

    ReadOnly Property InfoBox As System.Windows.Forms.GroupBox
        Get
            Return gBox
        End Get
    End Property


    'Mutators
    Private Sub TargetMe()
        Form1.TargetShip(Me)
    End Sub

    Public Function DoDamage(ByVal dmg As UInteger) As Boolean
        If dmg > nShields Then
            nShields = 0
            RemoveMe()
            Return True
        End If

        nShields -= dmg
        lblShields.Text = nShields
        Return False
    End Function

    Public Sub Kill()
        RemoveMe()
    End Sub


    'Cleanup
    Private Sub RemoveMe()
        Form1.RemoveEnemyShip(Me)
    End Sub
End Class
