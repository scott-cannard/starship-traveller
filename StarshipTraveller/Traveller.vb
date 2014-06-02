Public Class Traveller
    Public Enum Stat As Integer
        Disable = -1
        Weapons = 0
        Shields
        CaptainSkill
        CaptainStamina
        ScienceSkill
        ScienceStamina
        MedicalSkill
        MedicalStamina
        EngineerSkill
        EngineerStamina
        SecuritySkill
        SecurityStamina
        Guard1Skill
        Guard1Stamina
        Guard2Skill
        Guard2Stamina
        Luck
        MAX
    End Enum

    Public uStat(17) As UInteger
    Private nTargetIndex As Stat = Stat.Disable


    'Constructor
    Public Sub New(ByRef rand As Random)
        uStat(Stat.Weapons) = rand.Next(1, 7) + 6
        uStat(Stat.Shields) = rand.Next(1, 7) + 12

        uStat(Stat.CaptainSkill) = rand.Next(1, 7) + 6
        uStat(Stat.CaptainStamina) = rand.Next(1, 7) + rand.Next(1, 7) + 12
        uStat(Stat.ScienceSkill) = rand.Next(1, 7) + 6
        uStat(Stat.ScienceStamina) = rand.Next(1, 7) + rand.Next(1, 7) + 12
        uStat(Stat.MedicalSkill) = rand.Next(1, 7) + 6
        uStat(Stat.MedicalStamina) = rand.Next(1, 7) + rand.Next(1, 7) + 12
        uStat(Stat.EngineerSkill) = rand.Next(1, 7) + 6
        uStat(Stat.EngineerStamina) = rand.Next(1, 7) + rand.Next(1, 7) + 12
        uStat(Stat.SecuritySkill) = rand.Next(1, 7) + 6
        uStat(Stat.SecurityStamina) = rand.Next(1, 7) + rand.Next(1, 7) + 12
        uStat(Stat.Guard1Skill) = rand.Next(1, 7) + 6
        uStat(Stat.Guard1Stamina) = rand.Next(1, 7) + rand.Next(1, 7) + 12
        uStat(Stat.Guard2Skill) = rand.Next(1, 7) + 6
        uStat(Stat.Guard2Stamina) = rand.Next(1, 7) + rand.Next(1, 7) + 12

        uStat(Stat.Luck) = rand.Next(1, 7) + 6
    End Sub


    'Accessors
    ReadOnly Property Weapons As UInteger
        Get
            Return uStat(Stat.Weapons)
        End Get
    End Property

    ReadOnly Property Shields As UInteger
        Get
            Return uStat(Stat.Shields)
        End Get
    End Property

    ReadOnly Property CaptainSkill As UInteger
        Get
            Return uStat(Stat.CaptainSkill)
        End Get
    End Property

    ReadOnly Property CaptainStamina As UInteger
        Get
            Return uStat(Stat.CaptainStamina)
        End Get
    End Property

    ReadOnly Property ScienceSkill As UInteger
        Get
            Return uStat(Stat.ScienceSkill)
        End Get
    End Property

    ReadOnly Property ScienceStamina As UInteger
        Get
            Return uStat(Stat.ScienceStamina)
        End Get
    End Property

    ReadOnly Property MedicalSkill As UInteger
        Get
            Return uStat(Stat.MedicalSkill)
        End Get
    End Property

    ReadOnly Property MedicalStamina As UInteger
        Get
            Return uStat(Stat.MedicalStamina)
        End Get
    End Property

    ReadOnly Property EngineerSkill As UInteger
        Get
            Return uStat(Stat.EngineerSkill)
        End Get
    End Property

    ReadOnly Property EngineerStamina As UInteger
        Get
            Return uStat(Stat.EngineerStamina)
        End Get
    End Property

    ReadOnly Property SecuritySkill As UInteger
        Get
            Return uStat(Stat.SecuritySkill)
        End Get
    End Property

    ReadOnly Property SecurityStamina As UInteger
        Get
            Return uStat(Stat.SecurityStamina)
        End Get
    End Property

    ReadOnly Property Guard1Skill As UInteger
        Get
            Return uStat(Stat.Guard1Skill)
        End Get
    End Property

    ReadOnly Property Guard1Stamina As UInteger
        Get
            Return uStat(Stat.Guard1Stamina)
        End Get
    End Property

    ReadOnly Property Guard2Skill As UInteger
        Get
            Return uStat(Stat.Guard2Skill)
        End Get
    End Property

    ReadOnly Property Guard2Stamina As UInteger
        Get
            Return uStat(Stat.Guard2Stamina)
        End Get
    End Property

    ReadOnly Property Luck As UInteger
        Get
            Return uStat(Stat.Luck)
        End Get
    End Property


    'Mutators
    Public WriteOnly Property TargetStat As Stat
        Set(tgt As Stat)
            nTargetIndex = tgt
        End Set
    End Property

    Public Sub IncrementStat()
        If nTargetIndex > Stat.Disable And nTargetIndex < Stat.MAX Then
            uStat(nTargetIndex) += 1
        End If
    End Sub

    Public Sub DecrementStat()
        If nTargetIndex > Stat.Disable And nTargetIndex < Stat.MAX Then
            uStat(nTargetIndex) -= 1
        End If
    End Sub

    Public Function TakeDamage(ByVal dmg As UInteger) As Boolean
        If dmg > uStat(Stat.Shields) Then
            uStat(Stat.Shields) = 0
            Return True
        End If

        uStat(Stat.Shields) -= dmg
        Return False
    End Function
End Class
