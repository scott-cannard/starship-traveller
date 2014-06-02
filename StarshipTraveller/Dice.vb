Public Class Dice
    Private Const MAX_BUTTONS As UInteger = 3
    Private img As New System.Windows.Forms.ImageList

    Private nDieValue(3) As Integer

    Private gBox As New System.Windows.Forms.GroupBox
    Private btnDie(3) As System.Windows.Forms.Button


    'Constructor
    Public Sub New(ByRef rand As Random)
        img.Images.Add(New Bitmap("one.bmp", False))
        img.Images.Add(New Bitmap("two.bmp", False))
        img.Images.Add(New Bitmap("three.bmp", False))
        img.Images.Add(New Bitmap("four.bmp", False))
        img.Images.Add(New Bitmap("five.bmp", False))
        img.Images.Add(New Bitmap("six.bmp", False))

        gBox.Location = New Point(324, 201)
        gBox.Size = New Size(89, 39)

        For i = 0 To 2
            btnDie(i) = New Button
            btnDie(i).Location = New Point(2 + i * 29, 9)
            btnDie(i).Size = New Size(27, 27)
            btnDie(i).Hide()
            gBox.Controls.Add(btnDie(i))
        Next

        Reset(rand)
    End Sub


    'Accessors
    ReadOnly Property Total As Integer
        Get
            Return (nDieValue(0) + nDieValue(1) + nDieValue(2))
        End Get
    End Property

    ReadOnly Property InfoBox As System.Windows.Forms.GroupBox
        Get
            Return gBox
        End Get
    End Property


    'Mutators
    Public Sub Reset(ByRef rand As Random)
        For i = 0 To MAX_BUTTONS - 1
            btnDie(i).Hide()
            nDieValue(i) = rand.Next(1, 7)
            btnDie(i).Image = img.Images(nDieValue(i) - 1)
        Next
    End Sub

    Public Sub Roll(ByVal n As UInteger, ByRef rand As Random)
        Dim delay As New Stopwatch

        For s = 0 To MAX_BUTTONS - 1
            If s < n Then
                btnDie(s).Show()
            Else
                btnDie(s).Hide()
            End If
        Next

        For i = 1 To 17
            For die = 0 To n - 1
                nDieValue(die) = rand.Next(1, 7)
                btnDie(die).Image = img.Images(nDieValue(die) - 1)
            Next
            delay.Start()
            Do While delay.ElapsedMilliseconds < 75
                Application.DoEvents()
            Loop
            delay.Stop()
            delay.Reset()
        Next
    End Sub
End Class
