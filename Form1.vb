
Public Class Form1
    Dim Sound As New System.Media.SoundPlayer()
    Dim decimalbutton As Boolean
    Dim num1, num2
    Dim T_op, op, T_op1 As String
    Dim vol, Exp, EqualIsClicked, PosNeg As Boolean
    Dim ExpNum, counter As Integer
    Dim T_Num1, T_Num2, T_Result, ms, mr, mplus, mminus As Long
    Dim talk


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        talk = CreateObject("sapi.spvoice")
        Standard_Scientific(1)
        txtDisplay.Text = ""
        num1 = 0
        num2 = 0
        op = ""
        ExpNum = 0
        counter = 0
        decimalbutton = False
        LoadDefault()
        vol = True
        Exp = False
        PosNeg = True
        ms = 0
        mr = 0
        mplus = 0
        mminus = 0
        T_Num1 = 0
        T_Num2 = 0
        T_Result = 0
        T_op = ""
        T_op1 = ""
        txtTalk.Text = ""
        Label3.Visible = False
        EqualIsClicked = False
        lbl_Vol.Visible = False
        lbl_c.Visible = False
        lbl_Cc.Visible = False
        lbl_g.Visible = False
        lbl_h.Visible = False
        lbl_k.Visible = False
        lbl_e.Visible = False
        lbl_Permitive.Visible = False
        lbl_u.Visible = False
        lbl_z.Visible = False
        lbl_Rb.Visible = False
        lbl_Na.Visible = False
        lbl_F.Visible = False
        Sound.SoundLocation = Application.StartupPath & "\Wav\bounce.wav"  'ex.: c:\mysound.wav  
        Sound.Load()
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click    
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "7"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "8"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "9"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "9"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "4"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "5"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "6"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "6"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "1"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "2"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "3"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "3"
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "0"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "0"
    End Sub

    Private Sub btn00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn00.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text += "00"
            Exit Sub
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If
        txtDisplay.Text += "00"
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        If vol = True Then
            Sound.Play()
        End If
        If EqualIsClicked = True Then
            txtDisplay.Text = ""
            EqualIsClicked = False
        End If

        If decimalbutton = True Then
            Exit Sub
        Else
            If txtDisplay.Text <> "" Then
                txtDisplay.Text += "."
                decimalbutton = True
            End If
        End If
    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        If vol = True Then
            Sound.Play()
        End If
        If Exp = True Then
            txtDisplay.Text = ExpNum ^ Val(txtDisplay.Text)
            Exp = False
            EqualIsClicked = True
            Exit Sub
        End If
        decimalbutton = False
        num2 = Val(txtDisplay.Text)
        T_Num2 = num2

        Select Case op
            Case "-"
                txtDisplay.Text = num1 - num2
                T_Result = Val(txtDisplay.Text)
            Case "+"
                txtDisplay.Text = num1 + num2
                T_Result = Val(txtDisplay.Text)
            Case "/"
                txtDisplay.Text = num1 / num2
                T_Result = Val(txtDisplay.Text)
            Case "*"
                txtDisplay.Text = num1 * num2
                T_Result = Val(txtDisplay.Text)
            Case "Mod"
                txtDisplay.Text = num1 Mod num2
                T_Result = Val(txtDisplay.Text)
        End Select

        op = ""
        EqualIsClicked = True
        txtTalk.Text = ""
        txtHistory.Text += T_Num1 & vbCrLf & T_op1 & vbCrLf & T_Num2 & vbCrLf & "============" & vbCrLf & T_Result & vbCrLf & "============" & vbCrLf & vbCrLf
        txtHistory.SelectionStart = txtHistory.TextLength
        txtHistory.ScrollToCaret()
    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            op = "*"
            num1 = Val(txtDisplay.Text)
            txtDisplay.Text = ""
            decimalbutton = False
            T_Num1 = num1
            T_op = "Times"
            T_op1 = "x"
        End If
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            op = "+"
            num1 = Val(txtDisplay.Text)
            txtDisplay.Text = ""
            decimalbutton = False
            T_Num1 = num1
            T_op = "Plus"
            T_op1 = "+"
        End If
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            op = "/"
            num1 = Val(txtDisplay.Text)
            txtDisplay.Text = ""
            decimalbutton = False
            T_Num1 = num1
            T_op = "Divide"
            T_op1 = "/"
        End If
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            op = "-"
            num1 = Val(txtDisplay.Text)
            txtDisplay.Text = ""
            decimalbutton = False
            T_Num1 = num1
            T_op = "Minus"
            T_op1 = "-"
        End If
    End Sub

    Private Sub btnPlusMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusMinus.Click
        If vol = True Then
            Sound.Play()
        End If
        Try
            If txtDisplay.Text <> "" Then
                If txtDisplay.Text.Length = 0 Then
                    txtDisplay.Text = txtDisplay.Text + CStr("-")
                ElseIf txtDisplay.Text <> "." Then
                    txtDisplay.Text = txtDisplay.Text * -1
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If vol = True Then
            Sound.Play()
        End If
        op = ""
        txtDisplay.Text = ""
        num1 = 0
        num2 = 0
    End Sub

    Private Sub btnBkSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBkSpace.Click
        If vol = True Then
            Sound.Play()
        End If
        Try
            txtDisplay.Text = Microsoft.VisualBasic.Left(txtDisplay.Text, (Len(txtDisplay.Text) - 1))
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub ModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeToolStripMenuItem.Click

    End Sub

    Private Sub StandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardToolStripMenuItem.Click
        Standard_Scientific(1)
    End Sub

    Public Function Standard_Scientific(ByVal Mode As Integer) As Integer

        Select Case Mode

            Case 1

                ScientificToolStripMenuItem.Checked = False
                StandardToolStripMenuItem.Checked = True
                txtDisplay.Width = 250
                txtDisplay.Left = 21
                txtDisplay.Top = 39
                txtDisplay.Height = 30
                PictureBox1.Width = 294
                PictureBox1.Height = 69
                PictureBox1.Left = 0
                PictureBox1.Top = 23
                Me.Width = 300
                Me.Height = 398

            Case 2

                ScientificToolStripMenuItem.Checked = True
                StandardToolStripMenuItem.Checked = False
                txtDisplay.Width = 492
                txtDisplay.Height = 30
                txtDisplay.Left = 33
                txtDisplay.Top = 38
                PictureBox1.Width = 570
                PictureBox1.Height = 69
                PictureBox1.Left = 0
                PictureBox1.Top = 24
                Me.Width = 826
                Me.Height = 398

        End Select
    End Function


    Private Sub ScientificToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificToolStripMenuItem.Click
        Standard_Scientific(2)
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            op = "Mod"
            num1 = Val(txtDisplay.Text)
            txtDisplay.Text = ""
            decimalbutton = False
            T_Num1 = num1
            T_op = "Modulo"
            T_op1 = "%"
        End If
    End Sub

    Private Sub btnVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolume.Click
        Select Case vol
            Case True
                btnVolume.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Volume\vol.jpg")
                vol = False
            Case False
                btnVolume.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Volume\vol.png")
                vol = True
        End Select
    End Sub

    Private Sub btnBkSpace_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBkSpace.MouseDown
        MDown_MHover(1, 1)
    End Sub

    Private Sub btnBkSpace_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBkSpace.MouseHover
        MDown_MHover(1, 2)
    End Sub

    Private Sub btnBkSpace_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBkSpace.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnBkSpace_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBkSpace.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnClear_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClear.MouseDown
        MDown_MHover(2, 1)
    End Sub

    Private Sub btnClear_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.MouseHover
        MDown_MHover(2, 2)
    End Sub

    Private Sub btnClear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnClear_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnClear.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMS.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            ms = Val(txtDisplay.Text)
            mr = ms
            Label3.Visible = True
        End If
        EqualIsClicked = True
    End Sub

    Private Sub btnMS_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMS.MouseDown
        MDown_MHover(3, 1)
    End Sub

    Private Sub btnMS_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMS.MouseHover
        MDown_MHover(3, 2)
    End Sub

    Private Sub btnMS_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMS.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnMS_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMS.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMR.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = mr
        Label3.Visible = False
        EqualIsClicked = True
    End Sub

    Private Sub btnMR_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMR.DragLeave
        LoadDefault()
    End Sub

    Private Sub btnMR_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMR.MouseDown
        MDown_MHover(4, 1)
    End Sub

    Private Sub btnMR_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMR.MouseHover
        MDown_MHover(4, 2)
    End Sub

    Private Sub btnMR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMR.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnMR_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMR.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnMPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMPlus.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            txtDisplay.Text = Val(txtDisplay.Text) + mr
        End If
        EqualIsClicked = True
    End Sub

    Private Sub btnMPlus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMPlus.MouseDown
        MDown_MHover(5, 1)
    End Sub

    Private Sub btnMPlus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMPlus.MouseHover
        MDown_MHover(5, 2)
    End Sub

    Private Sub btnMPlus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMPlus.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnMPlus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMPlus.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnMMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMMinus.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            txtDisplay.Text = Val(txtDisplay.Text) + mr
        End If
        EqualIsClicked = True
    End Sub

    Private Sub btnMMinus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMMinus.MouseDown
        MDown_MHover(6, 1)
    End Sub

    Private Sub btnMMinus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMMinus.MouseHover
        MDown_MHover(6, 2)
    End Sub

    Private Sub btnMMinus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMMinus.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnMMinus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMMinus.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnSquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquare.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text <> "" Then
            txtDisplay.Text = Math.Sqrt(txtDisplay.Text)
        End If
        EqualIsClicked = True
    End Sub

    Private Sub btnSquare_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSquare.MouseDown
        MDown_MHover(7, 1)
    End Sub

    Private Sub btnSquare_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSquare.MouseHover
        MDown_MHover(7, 2)
    End Sub

    Private Sub btnSquare_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSquare.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnSquare_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSquare.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn7.MouseDown
        MDown_MHover(8, 1)
    End Sub

    Private Sub btn7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn7.MouseHover
        MDown_MHover(8, 2)
    End Sub

    Private Sub btn7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn7.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn7.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn8.MouseDown
        MDown_MHover(9, 1)
    End Sub

    Private Sub btn8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn8.MouseHover
        MDown_MHover(9, 2)
    End Sub

    Private Sub btn8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn8.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn8.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn9.MouseDown
        MDown_MHover(10, 1)
    End Sub

    Private Sub btn9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn9.MouseHover
        MDown_MHover(10, 2)
    End Sub

    Private Sub btn9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn9.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn9.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnMod_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMod.MouseDown
        MDown_MHover(11, 1)
    End Sub

    Private Sub btnMod_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMod.MouseHover
        MDown_MHover(11, 2)
    End Sub

    Private Sub btnMod_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMod.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnMod_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMod.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnDivide_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnDivide.MouseDown
        MDown_MHover(12, 1)
    End Sub

    Private Sub btnDivide_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDivide.MouseHover
        MDown_MHover(12, 2)
    End Sub

    Private Sub btnDivide_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDivide.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnDivide_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnDivide.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseDown
        MDown_MHover(13, 1)
    End Sub

    Private Sub btn4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.MouseHover
        MDown_MHover(13, 2)
    End Sub

    Private Sub btn4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn5.MouseDown
        MDown_MHover(14, 1)
    End Sub

    Private Sub btn5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn5.MouseHover
        MDown_MHover(14, 2)
    End Sub

    Private Sub btn5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn5.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn5.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn6.MouseDown
        MDown_MHover(15, 1)
    End Sub

    Private Sub btn6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn6.MouseHover
        MDown_MHover(15, 2)
    End Sub

    Private Sub btn6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn6.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn6.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnMulti_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMulti.MouseDown
        MDown_MHover(16, 1)
    End Sub

    Private Sub btnMulti_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMulti.MouseHover
        MDown_MHover(16, 2)
    End Sub

    Private Sub btnMulti_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMulti.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnMulti_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMulti.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnMinus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinus.MouseDown
        MDown_MHover(17, 1)
    End Sub

    Private Sub btnMinus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinus.MouseHover
        MDown_MHover(17, 2)
    End Sub

    Private Sub btnMinus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinus.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnMinus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinus.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseDown
        MDown_MHover(18, 1)
    End Sub

    Private Sub btn1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.MouseHover
        MDown_MHover(18, 2)
    End Sub

    Private Sub btn1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseDown
        MDown_MHover(19, 1)
    End Sub

    Private Sub btn2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.MouseHover
        MDown_MHover(19, 2)
    End Sub

    Private Sub btn2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseDown
        MDown_MHover(20, 1)
    End Sub

    Private Sub btn3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.MouseHover
        MDown_MHover(20, 2)
    End Sub

    Private Sub btn3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnPlus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPlus.MouseDown
        MDown_MHover(21, 1)
    End Sub

    Private Sub btnPlus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlus.MouseHover
        MDown_MHover(21, 2)
    End Sub

    Private Sub btnPlus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlus.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnPlus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPlus.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnPlusMinus_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPlusMinus.MouseDown
        MDown_MHover(22, 1)
    End Sub

    Private Sub btnPlusMinus_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlusMinus.MouseHover
        MDown_MHover(22, 2)
    End Sub

    Private Sub btnPlusMinus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlusMinus.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnPlusMinus_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPlusMinus.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn0_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn0.MouseDown
        MDown_MHover(23, 1)
    End Sub

    Private Sub btn0_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn0.MouseHover
        MDown_MHover(23, 2)
    End Sub

    Private Sub btn0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn0.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn0_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn0.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn00_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn00.MouseDown
        MDown_MHover(24, 1)
    End Sub

    Private Sub btn00_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn00.MouseHover
        MDown_MHover(24, 2)
    End Sub

    Private Sub btn00_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn00.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn00_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn00.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnDecimal_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnDecimal.MouseDown
        MDown_MHover(25, 1)
    End Sub

    Private Sub btnDecimal_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecimal.MouseHover
        MDown_MHover(25, 2)
    End Sub

    Private Sub btnDecimal_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecimal.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnDecimal_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnDecimal.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnEquals_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEquals.MouseDown
        MDown_MHover(26, 1)
    End Sub

    Private Sub btnEquals_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEquals.MouseHover
        MDown_MHover(26, 2)
    End Sub

    Private Sub btnEquals_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEquals.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnEquals_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEquals.MouseUp
        LoadDefault()
    End Sub

    Private Sub GroupBox8_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsin.Click
        If vol = True Then
            Sound.Play()
        End If
        If Len(txtDisplay.Text) <> 0 Then
            txtDisplay.Text = Math.Sin(txtDisplay.Text)
        End If
    End Sub

    Private Sub btnTalk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalk.Click
        If vol = True Then
            Sound.Play()
        End If
        Timer1.Enabled = True
        
    End Sub

    Private Sub btnTalk_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnTalk.MouseDown
        MDown_MHover(27, 1)
    End Sub

    Private Sub btnTalk_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTalk.MouseHover
        MDown_MHover(27, 2)
    End Sub

    Private Sub btnTalk_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTalk.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnTalk_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnTalk.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPi.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "3.1416"
        EqualIsClicked = True
    End Sub

    Private Sub btnPi_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPi.MouseDown
        MDown_MHover(28, 1)
    End Sub

    Private Sub btnPi_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPi.MouseHover
        MDown_MHover(28, 2)
    End Sub

    Private Sub btnPi_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPi.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnPi_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPi.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnEX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEX.Click
        If vol = True Then
            Sound.Play()
        End If
        If Len(txtDisplay.Text) <> 0 Then
            txtDisplay.Text = Math.Exp(txtDisplay.Text)
        End If
    End Sub

    Private Sub btnEX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEX.MouseDown
        MDown_MHover(29, 1)
    End Sub

    Private Sub btnEX_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEX.MouseHover
        MDown_MHover(29, 2)
    End Sub

    Private Sub btnEX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEX.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnEX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEX.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnln.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text.Length <> 0 Then
            txtDisplay.Text = Math.Log(txtDisplay.Text)
        End If
    End Sub

    Private Sub btnln_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnln.MouseDown
        MDown_MHover(30, 1)
    End Sub

    Private Sub btnln_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnln.MouseHover
        MDown_MHover(30, 2)
    End Sub

    Private Sub btnln_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnln.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnln_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnln.MouseUp
        LoadDefault()
    End Sub

    Private Sub btne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btne.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = Math.E
    End Sub

    Private Sub btne_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btne.MouseDown
        MDown_MHover(31, 1)
    End Sub

    Private Sub btne_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btne.MouseHover
        MDown_MHover(31, 2)
    End Sub

    Private Sub btne_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btne.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btne_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btne.MouseUp
        LoadDefault()
    End Sub

    Private Sub btn1x_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1x.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = 1 / txtDisplay.Text
    End Sub

    Private Sub btn1x_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1x.MouseDown
        MDown_MHover(32, 1)
    End Sub

    Private Sub btn1x_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1x.MouseHover
        MDown_MHover(32, 2)
    End Sub

    Private Sub btn1x_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1x.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btn1x_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1x.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnx.Click
        If vol = True Then
            Sound.Play()
        End If
    End Sub

    Private Sub btnx_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx.MouseDown
        MDown_MHover(33, 1)
    End Sub

    Private Sub btnx_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx.MouseHover
        MDown_MHover(33, 2)
    End Sub

    Private Sub btnx_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnx_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnnPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnPr.Click
        If vol = True Then
            Sound.Play()
        End If
    End Sub

    Private Sub btnnPr_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnPr.MouseDown
        MDown_MHover(34, 1)
    End Sub

    Private Sub btnnPr_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnPr.MouseHover
        MDown_MHover(34, 2)
    End Sub

    Private Sub btnnPr_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnPr.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnnPr_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnPr.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnnCr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnCr.Click
        If vol = True Then
            Sound.Play()
        End If
    End Sub

    Private Sub btnnCr_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnCr.MouseDown
        MDown_MHover(35, 1)
    End Sub

    Private Sub btnnCr_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnCr.MouseHover
        MDown_MHover(35, 2)
    End Sub

    Private Sub btnnCr_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnCr.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnnCr_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnCr.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlog.Click
        If vol = True Then
            Sound.Play()
        End If
        If txtDisplay.Text.Length <> 0 Then
            txtDisplay.Text = Math.Log10(txtDisplay.Text)
        End If
    End Sub

    Private Sub btnlog_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlog.MouseDown
        MDown_MHover(36, 1)
    End Sub

    Private Sub btnlog_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlog.MouseHover
        MDown_MHover(36, 2)
    End Sub

    Private Sub btnlog_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlog.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnlog_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnlog.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactorial.Click
        Dim n, m As Long
        If vol = True Then
            Sound.Play()
        End If
        Try
            n = Val(txtDisplay.Text)
            m = 1
            Do While n > 1
                m = m * n
                n -= 1
            Loop
            txtDisplay.Text = m
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        EqualIsClicked = True
    End Sub

    Private Sub btnPercent_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFactorial.MouseDown
        MDown_MHover(37, 1)
    End Sub

    Private Sub btnPercent_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFactorial.MouseHover
        MDown_MHover(37, 2)
    End Sub

    Private Sub btnPercent_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFactorial.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnPercent_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFactorial.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnCc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCc.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "8.987 x 10^9 Nm^2/Coulombs^2"
        EqualIsClicked = True
    End Sub

    Private Sub btnCc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCc.MouseDown
        MDown_MHover(38, 1)
        lbl_Cc.Visible = False
    End Sub

    Private Sub btnCc_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCc.MouseHover
        MDown_MHover(38, 2)
        lbl_Cc.Text = "  Coulombs Constant   "
        lbl_Cc.Top = GroupBox4.Top + btnCc.Top - 2
        lbl_Cc.Left = GroupBox4.Left - 40
        lbl_Cc.Visible = True
    End Sub

    Private Sub btnCc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCc.MouseLeave
        LoadDefault()
        lbl_Cc.Visible = False
    End Sub

    Private Sub btnCc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCc.MouseUp
        LoadDefault()
        lbl_Cc.Visible = True
    End Sub

    Private Sub btng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btng.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "9.806 m/s^2"
        EqualIsClicked = True
    End Sub

    Private Sub btng_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btng.MouseDown
        MDown_MHover(39, 1)
        lbl_g.Visible = False
    End Sub

    Private Sub btng_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btng.MouseHover
        MDown_MHover(39, 2)
        lbl_g.Text = "  Gravitational Acceleration   "
        lbl_g.Top = GroupBox4.Top + btng.Top - 2
        lbl_g.Left = GroupBox4.Left - 15
        lbl_g.Visible = True
    End Sub

    Private Sub btng_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btng.MouseLeave
        LoadDefault()
        lbl_g.Visible = False
    End Sub

    Private Sub btng_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btng.MouseUp
        LoadDefault()
        lbl_g.Visible = True
    End Sub

    Private Sub btnh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnh.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "6.67 x 10^-11 m^3/kg/s^2"
        EqualIsClicked = True
    End Sub

    Private Sub btnh_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnh.MouseDown
        MDown_MHover(40, 1)
        lbl_h.Visible = False
    End Sub

    Private Sub btnh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnh.MouseHover
        MDown_MHover(40, 2)
        lbl_h.Text = "  Planks Constant   "
        lbl_h.Top = GroupBox4.Top + btnh.Top - 2
        lbl_h.Left = GroupBox4.Left + 65
        lbl_h.Visible = True
    End Sub

    Private Sub btnh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnh.MouseLeave
        LoadDefault()
        lbl_h.Visible = False
    End Sub

    Private Sub btnh_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnh.MouseUp
        LoadDefault()
        lbl_h.Visible = True
    End Sub

    Private Sub btnk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnk.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "1.3807 x 10^-23 J/K"
        EqualIsClicked = True
    End Sub

    Private Sub btnk_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnk.MouseDown
        MDown_MHover(41, 1)
        lbl_k.Visible = False
    End Sub

    Private Sub btnk_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnk.MouseHover
        MDown_MHover(41, 2)
        lbl_k.Text = "  Boltzmans Constant   "
        lbl_k.Top = GroupBox4.Top + btnk.Top - 2
        lbl_k.Left = GroupBox4.Left + 105
        lbl_k.Visible = True
    End Sub

    Private Sub btnk_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnk.MouseLeave
        LoadDefault()
        lbl_k.Visible = False
    End Sub

    Private Sub btnk_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnk.MouseUp
        LoadDefault()
        lbl_k.Visible = True
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "3.0 x 10^8 m/s"
        EqualIsClicked = True
    End Sub

    Private Sub btnc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnc.MouseDown
        MDown_MHover(42, 1)
        lbl_c.Visible = False
    End Sub

    Private Sub btnc_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnc.MouseHover
        MDown_MHover(42, 2)
        lbl_c.Text = "  Speed Of Light   "
        lbl_c.Top = GroupBox4.Top + btnc.Top - 2
        lbl_c.Left = GroupBox4.Left - 26
        lbl_c.Visible = True
    End Sub

    Private Sub btnc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnc.MouseLeave
        LoadDefault()
        lbl_c.Visible = False
    End Sub

    Private Sub btnc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnc.MouseUp
        LoadDefault()
        lbl_c.Visible = True
    End Sub

    Private Sub btn_E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_E.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "8.85 x 10^-12 F/m"
        EqualIsClicked = True
    End Sub

    Private Sub btn_E_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_E.MouseDown
        MDown_MHover(43, 1)
        lbl_Permitive.Visible = False
    End Sub

    Private Sub btn_E_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_E.MouseHover
        MDown_MHover(43, 2)
        lbl_Permitive.Text = "  Permitivity of Vacuum   "
        lbl_Permitive.Top = GroupBox4.Top + btn_E.Top - 2
        lbl_Permitive.Left = GroupBox4.Left + 8
        lbl_Permitive.Visible = True
    End Sub

    Private Sub btn_E_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_E.MouseLeave
        LoadDefault()
        lbl_Permitive.Visible = False
    End Sub

    Private Sub btn_E_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_E.MouseUp
        LoadDefault()
        lbl_Permitive.Visible = True
    End Sub

    Private Sub btn_ee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ee.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "1.6022 x 10^-22 coulombs"
        EqualIsClicked = True
    End Sub

    Private Sub btn_ee_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_ee.MouseDown
        MDown_MHover(44, 1)
        lbl_e.Visible = False
    End Sub

    Private Sub btn_ee_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ee.MouseHover
        MDown_MHover(44, 2)
        lbl_e.Text = "  Charge Of Electron   "
        lbl_e.Top = GroupBox4.Top + btn_ee.Top - 2
        lbl_e.Left = GroupBox4.Left + 50
        lbl_e.Visible = True
    End Sub

    Private Sub btn_ee_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ee.MouseLeave
        LoadDefault()
        lbl_e.Visible = False
    End Sub

    Private Sub btn_ee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_ee.MouseUp
        LoadDefault()
        lbl_e.Visible = True
    End Sub

    Private Sub btnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnu.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "1.2566 x 10 ^ -6 N/A^2"
        EqualIsClicked = True
    End Sub

    Private Sub btnu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnu.MouseDown
        MDown_MHover(45, 1)
        lbl_u.Visible = False
    End Sub

    Private Sub btnu_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnu.MouseHover
        MDown_MHover(45, 2)
        lbl_u.Text = "  Permeability of Vacuum   "
        lbl_u.Top = GroupBox4.Top + btnu.Top - 2
        lbl_u.Left = GroupBox4.Left + 95
        lbl_u.Visible = True
    End Sub

    Private Sub btnu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnu.MouseLeave
        LoadDefault()
        lbl_u.Visible = False
    End Sub

    Private Sub btnu_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnu.MouseUp
        LoadDefault()
        lbl_u.Visible = True
    End Sub

    Private Sub btnz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnz.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "3.767 x 10^2 ohms"
        EqualIsClicked = True
    End Sub

    Private Sub btnz_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnz.MouseDown
        MDown_MHover(46, 1)
        lbl_z.Visible = False
    End Sub

    Private Sub btnz_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnz.MouseHover
        MDown_MHover(46, 2)
        lbl_z.Text = "  Impedence Of Vaccum   "
        lbl_z.Top = GroupBox4.Top + btnz.Top - 2
        lbl_z.Left = GroupBox4.Left - 45
        lbl_z.Visible = True
    End Sub

    Private Sub btnz_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnz.MouseLeave
        LoadDefault()
        lbl_z.Visible = False
    End Sub

    Private Sub btnz_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnz.MouseUp
        LoadDefault()
        lbl_z.Visible = True
    End Sub

    Private Sub btnRb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRb.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "5.2918 x 10^-11 m"
        EqualIsClicked = True
    End Sub

    Private Sub btnRb_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRb.MouseDown
        MDown_MHover(47, 1)
        lbl_Rb.Visible = False
    End Sub

    Private Sub btnRb_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRb.MouseHover
        MDown_MHover(47, 2)
        lbl_Rb.Text = "  Bohrs Radius   "
        lbl_Rb.Top = GroupBox4.Top + btnRb.Top - 2
        lbl_Rb.Left = GroupBox4.Left + 20
        lbl_Rb.Visible = True
    End Sub

    Private Sub btnRb_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRb.MouseLeave
        LoadDefault()
        lbl_Rb.Visible = False
    End Sub

    Private Sub btnRb_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRb.MouseUp
        LoadDefault()
        lbl_Rb.Visible = True
    End Sub

    Private Sub btnNa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNa.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "6.022 x 10^23 mol^-1"
        EqualIsClicked = True
    End Sub

    Private Sub btnNa_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNa.MouseDown
        MDown_MHover(48, 1)
        lbl_Na.Visible = False
    End Sub

    Private Sub btnNa_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNa.MouseHover
        MDown_MHover(48, 2)
        lbl_Na.Text = "  Avogadros Number   "
        lbl_Na.Top = GroupBox4.Top + btnNa.Top - 2
        lbl_Na.Left = GroupBox4.Left + 55
        lbl_Na.Visible = True
    End Sub

    Private Sub btnNa_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNa.MouseLeave
        LoadDefault()
        lbl_Na.Visible = False
    End Sub

    Private Sub btnNa_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNa.MouseUp
        LoadDefault()
        lbl_Na.Visible = True
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = "9.6485 x 10^4 C/mol"
        EqualIsClicked = True
    End Sub

    Private Sub btnF_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnF.MouseDown
        MDown_MHover(49, 1)
        lbl_F.Visible = False
    End Sub

    Private Sub btnF_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF.MouseHover
        MDown_MHover(49, 2)
        lbl_F.Text = "  Faradays Constant   "
        lbl_F.Top = GroupBox4.Top + btnF.Top - 2
        lbl_F.Left = GroupBox4.Left + 96
        lbl_F.Visible = True
    End Sub

    Private Sub btnF_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF.MouseLeave
        LoadDefault()
        lbl_F.Visible = False
    End Sub

    Private Sub btnF_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnF.MouseUp
        LoadDefault()
        lbl_F.Visible = True
    End Sub

    Private Sub btnAnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnd.Click
        If vol = True Then
            Sound.Play()
        End If
        MessageBox.Show("This Part is not been coded yet !!!! ")
    End Sub

    Private Sub btnAnd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAnd.MouseDown
        MDown_MHover(50, 1)
    End Sub

    Private Sub btnAnd_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnd.MouseHover
        MDown_MHover(50, 2)
    End Sub

    Private Sub btnAnd_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnd.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnAnd_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAnd.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnOr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOr.Click
        If vol = True Then
            Sound.Play()
        End If
        MessageBox.Show("This Part is not been coded yet !!!! ")
    End Sub

    Private Sub btnOr_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOr.MouseDown
        MDown_MHover(51, 1)
    End Sub

    Private Sub btnOr_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOr.MouseHover
        MDown_MHover(51, 2)
    End Sub

    Private Sub btnOr_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOr.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnOr_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOr.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnNot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNot.Click
        If vol = True Then
            Sound.Play()
        End If
        MessageBox.Show("This Part is not been coded yet !!!! ")
    End Sub

    Private Sub btnNot_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNot.MouseDown
        MDown_MHover(52, 1)
    End Sub

    Private Sub btnNot_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNot.MouseHover
        MDown_MHover(52, 2)
    End Sub

    Private Sub btnNot_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNot.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnNot_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNot.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnXor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXor.Click
        If vol = True Then
            Sound.Play()
        End If
        MessageBox.Show("This Part is not been coded yet !!!! ")
    End Sub

    Private Sub btnXor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnXor.MouseDown
        MDown_MHover(53, 1)
    End Sub

    Private Sub btnXor_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXor.MouseHover
        MDown_MHover(53, 2)
    End Sub

    Private Sub btnXor_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXor.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnXor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnXor.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRound.Click
        If vol = True Then
            Sound.Play()
        End If
        Try
            txtDisplay.Text = Math.Round(Val(txtDisplay.Text))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnRound_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRound.MouseDown
        MDown_MHover(54, 1)
    End Sub

    Private Sub btnRound_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRound.MouseHover
        MDown_MHover(54, 2)
    End Sub

    Private Sub btnRound_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRound.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnRound_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRound.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnFloor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFloor.Click
        If vol = True Then
            Sound.Play()
        End If
        Try
            txtDisplay.Text = Math.Floor(Val(txtDisplay.Text))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnFloor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFloor.MouseDown
        MDown_MHover(55, 1)
    End Sub

    Private Sub btnFloor_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFloor.MouseHover
        MDown_MHover(55, 2)
    End Sub

    Private Sub btnFloor_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFloor.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnFloor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnFloor.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnTrunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrunc.Click
        If vol = True Then
            Sound.Play()
        End If
        Try
            txtDisplay.Text = Math.Truncate(Val(txtDisplay.Text))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnTrunc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnTrunc.MouseDown
        MDown_MHover(56, 1)
    End Sub

    Private Sub btnTrunc_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTrunc.MouseHover
        MDown_MHover(56, 2)
    End Sub

    Private Sub btnTrunc_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTrunc.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnTrunc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnTrunc.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnCeil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeil.Click
        If vol = True Then
            Sound.Play()
        End If
        Try
            txtDisplay.Text = Math.Ceiling(Val(txtDisplay.Text))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnCeil_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCeil.MouseDown
        MDown_MHover(57, 1)
    End Sub

    Private Sub btnCeil_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCeil.MouseHover
        MDown_MHover(57, 2)
    End Sub

    Private Sub btnCeil_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCeil.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnCeil_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnCeil.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnxy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxy.Click
        If vol = True Then
            Sound.Play()
        End If
        Exp = True
        ExpNum = Val(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub

    Private Sub btnxy_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnxy.MouseDown
        MDown_MHover(58, 1)
    End Sub

    Private Sub btnxy_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnxy.MouseHover
        MDown_MHover(58, 2)
    End Sub

    Private Sub btnxy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnxy.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnxy_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnxy.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnx2.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = Val(txtDisplay.Text) ^ 2
    End Sub

    Private Sub btnx2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx2.MouseDown
        MDown_MHover(59, 1)
    End Sub

    Private Sub btnx2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx2.MouseHover
        MDown_MHover(59, 2)
    End Sub

    Private Sub btnx2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx2.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnx2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx2.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnx3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnx3.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = Val(txtDisplay.Text) ^ 3
    End Sub

    Private Sub btnx3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx3.MouseDown
        MDown_MHover(60, 1)
    End Sub

    Private Sub btnx3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx3.MouseHover
        MDown_MHover(60, 2)
    End Sub

    Private Sub btnx3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx3.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnx3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx3.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnx4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnx4.Click
        If vol = True Then
            Sound.Play()
        End If
        txtDisplay.Text = Val(txtDisplay.Text) ^ 4
    End Sub

    Private Sub btnx4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx4.MouseDown
        MDown_MHover(61, 1)
    End Sub

    Private Sub btnx4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx4.MouseHover
        MDown_MHover(61, 2)
    End Sub

    Private Sub btnx4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnx4.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnx4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnx4.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnsin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsin.MouseDown
        MDown_MHover(62, 1)
    End Sub

    Private Sub btnsin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsin.MouseHover
        MDown_MHover(62, 2)
    End Sub

    Private Sub btnsin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsin.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnsin_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsin.MouseUp
        LoadDefault()
    End Sub

    Private Sub btncos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncos.Click
        If vol = True Then
            Sound.Play()
        End If
        If Len(txtDisplay.Text) <> 0 Then
            txtDisplay.Text = Math.Cos(txtDisplay.Text)
        End If
    End Sub

    Private Sub btncos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncos.MouseDown
        MDown_MHover(63, 1)
    End Sub

    Private Sub btncos_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncos.MouseHover
        MDown_MHover(63, 2)
    End Sub

    Private Sub btncos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncos.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btncos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncos.MouseUp
        LoadDefault()
    End Sub

    Private Sub btntan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntan.Click
        If vol = True Then
            Sound.Play()
        End If
        If Len(txtDisplay.Text) <> 0 Then
            txtDisplay.Text = Math.Tan(txtDisplay.Text)
        End If
    End Sub

    Private Sub btntan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btntan.MouseDown
        MDown_MHover(64, 1)
    End Sub

    Private Sub btntan_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntan.MouseHover
        MDown_MHover(64, 2)
    End Sub

    Private Sub btntan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntan.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btntan_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btntan.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnsinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsinh.Click
        If vol = True Then
            Sound.Play()
        End If
        If Len(txtDisplay.Text) <> 0 Then
            txtDisplay.Text = Math.Sinh(txtDisplay.Text)
        End If
    End Sub

    Private Sub btnsinh_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsinh.MouseDown
        MDown_MHover(65, 1)
    End Sub

    Private Sub btnsinh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsinh.MouseHover
        MDown_MHover(65, 2)
    End Sub

    Private Sub btnsinh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsinh.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btnsinh_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnsinh.MouseUp
        LoadDefault()
    End Sub

    Private Sub btncosh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncosh.Click
        If vol = True Then
            Sound.Play()
        End If
        If Len(txtDisplay.Text) <> 0 Then
            txtDisplay.Text = Math.Cosh(txtDisplay.Text)
        End If
    End Sub

    Private Sub btncosh_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncosh.MouseDown
        MDown_MHover(66, 1)
    End Sub

    Private Sub btncosh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncosh.MouseHover
        MDown_MHover(66, 2)
    End Sub

    Private Sub btncosh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncosh.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btncosh_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncosh.MouseUp
        LoadDefault()
    End Sub

    Private Sub btntanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntanh.Click
        If vol = True Then
            Sound.Play()
        End If
        If Len(txtDisplay.Text) <> 0 Then
            txtDisplay.Text = Math.Tanh(txtDisplay.Text)
        End If
    End Sub

    Private Sub btntanh_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btntanh.MouseDown
        MDown_MHover(67, 1)
    End Sub

    Private Sub btntanh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntanh.MouseHover
        MDown_MHover(67, 2)
    End Sub

    Private Sub btntanh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntanh.MouseLeave
        LoadDefault()
    End Sub

    Private Sub btntanh_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btntanh.MouseUp
        LoadDefault()
    End Sub

    Private Sub btnVolume_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnVolume.MouseDown
        lbl_Vol.Visible = False
    End Sub

    Private Sub btnVolume_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolume.MouseHover
        lbl_Vol.Text = "  Turn Off/On Sound   "
        lbl_Vol.Top = btnVolume.Top - 15
        lbl_Vol.Left = btnVolume.Left - 40
        lbl_Vol.Visible = True
    End Sub

    Private Sub lbl_Vol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Vol.Click

    End Sub

    Private Sub btnVolume_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolume.MouseLeave
        lbl_Vol.Visible = False
    End Sub

    Private Sub btnVolume_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnVolume.MouseUp
        lbl_Vol.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        counter += 1

        If counter = 2 Then
            txtTalk.Text = txtTalk.Text & CStr(T_Num1) & "  "
            talk.speak(T_Num1)
        ElseIf counter = 4 Then
            txtTalk.Text = txtTalk.Text & T_op1 & "  "
            talk.speak(T_op)
        ElseIf counter = 6 Then
            txtTalk.Text = txtTalk.Text & CStr(T_Num2) & "  "
            talk.speak(T_Num2)
        ElseIf counter = 8 Then
            txtTalk.Text = txtTalk.Text & " = "
            talk.speak("Equals")
        ElseIf counter = 10 Then
            txtTalk.Text = txtTalk.Text & CStr(T_Result)
            talk.speak(T_Result)
            counter = 0
            Timer1.Enabled = False
        End If
    End Sub
    
    Private Sub ShowHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHistoryToolStripMenuItem.Click
        txtHistory.Text = ""
    End Sub
End Class
