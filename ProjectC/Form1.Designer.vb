<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Btn_Sansyou = New Button()
        btn_Touroku = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button5 = New Button()
        btn_end = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("メイリオ", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(427, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 60)
        Label1.TabIndex = 0
        Label1.Text = "メイン画面"
        ' 
        ' Btn_Sansyou
        ' 
        Btn_Sansyou.Anchor = AnchorStyles.None
        Btn_Sansyou.Location = New Point(51, 266)
        Btn_Sansyou.Name = "Btn_Sansyou"
        Btn_Sansyou.Size = New Size(313, 134)
        Btn_Sansyou.TabIndex = 2
        Btn_Sansyou.Text = "参照"
        Btn_Sansyou.UseVisualStyleBackColor = True
        ' 
        ' btn_Touroku
        ' 
        btn_Touroku.Anchor = AnchorStyles.None
        btn_Touroku.Location = New Point(51, 29)
        btn_Touroku.Name = "btn_Touroku"
        btn_Touroku.Size = New Size(313, 134)
        btn_Touroku.TabIndex = 3
        btn_Touroku.Text = "登録"
        btn_Touroku.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.Location = New Point(50, 20)
        Button3.Name = "Button3"
        Button3.Size = New Size(313, 134)
        Button3.TabIndex = 4
        Button3.Text = "入力"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btn_Touroku)
        Panel1.Controls.Add(Btn_Sansyou)
        Panel1.Location = New Point(37, 72)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(425, 421)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button3)
        Panel2.Location = New Point(613, 81)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(408, 175)
        Panel2.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Button5)
        Panel3.Location = New Point(613, 318)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(408, 175)
        Panel3.TabIndex = 8
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.Location = New Point(50, 20)
        Button5.Name = "Button5"
        Button5.Size = New Size(313, 134)
        Button5.TabIndex = 4
        Button5.Text = "売上参照"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' btn_end
        ' 
        btn_end.Anchor = AnchorStyles.None
        btn_end.Location = New Point(909, 499)
        btn_end.Name = "btn_end"
        btn_end.Size = New Size(112, 76)
        btn_end.TabIndex = 9
        btn_end.Text = "終了"
        btn_end.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(794, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 36)
        Label2.TabIndex = 10
        Label2.Text = "受注"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(794, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 36)
        Label3.TabIndex = 11
        Label3.Text = "売上"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(196, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 36)
        Label4.TabIndex = 12
        Label4.Text = "顧客登録"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1042, 587)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btn_end)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Sansyou As Button
    Friend WithEvents btn_Touroku As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
