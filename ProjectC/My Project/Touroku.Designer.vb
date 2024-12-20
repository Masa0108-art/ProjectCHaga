<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Touroku
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btn_mainback = New Button()
        DataGridView1 = New DataGridView()
        btn_signup = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBox12 = New TextBox()
        Label13 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Label14 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("メイリオ", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(785, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 36)
        Label1.TabIndex = 0
        Label1.Text = "顧客登録画面"
        ' 
        ' btn_mainback
        ' 
        btn_mainback.Anchor = AnchorStyles.None
        btn_mainback.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btn_mainback.Location = New Point(12, 12)
        btn_mainback.Name = "btn_mainback"
        btn_mainback.Size = New Size(154, 58)
        btn_mainback.TabIndex = 1
        btn_mainback.Text = "メイン画面へ戻る"
        btn_mainback.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 203)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1669, 321)
        DataGridView1.TabIndex = 2
        ' 
        ' btn_signup
        ' 
        btn_signup.Anchor = AnchorStyles.None
        btn_signup.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btn_signup.Location = New Point(1600, 133)
        btn_signup.Name = "btn_signup"
        btn_signup.Size = New Size(81, 64)
        btn_signup.TabIndex = 3
        btn_signup.Text = "登録"
        btn_signup.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Location = New Point(13, 28)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(83, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Location = New Point(102, 28)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(83, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(39, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 25)
        Label2.TabIndex = 6
        Label2.Text = "姓"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(130, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 25)
        Label3.TabIndex = 7
        Label3.Text = "名"
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.None
        TextBox3.Location = New Point(192, 28)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(268, 31)
        TextBox3.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(268, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 25)
        Label4.TabIndex = 9
        Label4.Text = "メールアドレス"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.None
        TextBox4.Location = New Point(465, 28)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(188, 31)
        TextBox4.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(517, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 11
        Label5.Text = "電話番号"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.None
        TextBox5.Location = New Point(659, 28)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(84, 31)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.None
        TextBox6.Location = New Point(746, 28)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(84, 31)
        TextBox6.TabIndex = 13
        ' 
        ' TextBox7
        ' 
        TextBox7.Anchor = AnchorStyles.None
        TextBox7.Location = New Point(836, 28)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(80, 31)
        TextBox7.TabIndex = 14
        ' 
        ' TextBox8
        ' 
        TextBox8.Anchor = AnchorStyles.None
        TextBox8.Location = New Point(922, 28)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(123, 31)
        TextBox8.TabIndex = 15
        ' 
        ' TextBox9
        ' 
        TextBox9.Anchor = AnchorStyles.None
        TextBox9.Location = New Point(1051, 28)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(208, 31)
        TextBox9.TabIndex = 16
        ' 
        ' TextBox10
        ' 
        TextBox10.Anchor = AnchorStyles.None
        TextBox10.Location = New Point(1265, 28)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(92, 31)
        TextBox10.TabIndex = 17
        ' 
        ' TextBox11
        ' 
        TextBox11.Anchor = AnchorStyles.None
        TextBox11.Location = New Point(1363, 28)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(84, 31)
        TextBox11.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Location = New Point(659, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 25)
        Label6.TabIndex = 19
        Label6.Text = "都道府県"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Location = New Point(746, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 25)
        Label7.TabIndex = 20
        Label7.Text = "市区町村"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Location = New Point(851, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 25)
        Label8.TabIndex = 21
        Label8.Text = "町名"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Location = New Point(937, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 25)
        Label9.TabIndex = 22
        Label9.Text = "丁目番地"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Location = New Point(1283, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 25)
        Label10.TabIndex = 23
        Label10.Text = "号室"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Location = New Point(1379, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(48, 25)
        Label11.TabIndex = 24
        Label11.Text = "性別"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Location = New Point(1478, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 25)
        Label12.TabIndex = 25
        Label12.Text = "ポイント"
        ' 
        ' TextBox12
        ' 
        TextBox12.Anchor = AnchorStyles.None
        TextBox12.Location = New Point(1451, 28)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(124, 31)
        TextBox12.TabIndex = 26
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Location = New Point(1121, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(66, 25)
        Label13.TabIndex = 27
        Label13.Text = "建物名"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(TextBox12)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox11)
        Panel1.Controls.Add(TextBox9)
        Panel1.Controls.Add(TextBox10)
        Panel1.Location = New Point(12, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1582, 73)
        Panel1.TabIndex = 28
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Location = New Point(655, 537)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 29
        Button1.Text = "前へ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Location = New Point(951, 537)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 30
        Button2.Text = "次へ"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Location = New Point(838, 542)
        Label14.Name = "Label14"
        Label14.Size = New Size(22, 25)
        Label14.TabIndex = 31
        Label14.Text = "1"
        ' 
        ' Touroku
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1693, 578)
        Controls.Add(Label14)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(btn_signup)
        Controls.Add(DataGridView1)
        Controls.Add(btn_mainback)
        Controls.Add(Label1)
        Name = "Touroku"
        Text = "Touroku"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_mainback As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_signup As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
End Class
