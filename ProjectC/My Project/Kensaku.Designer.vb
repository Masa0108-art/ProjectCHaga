<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kensaku
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
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Anchor = AnchorStyles.None
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(84, 164)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(22, 21)
        CheckBox1.TabIndex = 0
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("メイリオ", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(293, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 54)
        Label1.TabIndex = 1
        Label1.Text = "顧客詳細検索"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("メイリオ", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(112, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 42)
        Label2.TabIndex = 2
        Label2.Text = "顧客名"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("メイリオ", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(112, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 42)
        Label3.TabIndex = 3
        Label3.Text = "電話番号"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("メイリオ", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(112, 391)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 42)
        Label4.TabIndex = 4
        Label4.Text = "都道府県"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("メイリオ", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(112, 526)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 42)
        Label5.TabIndex = 5
        Label5.Text = "市区町村"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button1.Location = New Point(12, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(201, 62)
        Button1.TabIndex = 6
        Button1.Text = "参照画面へ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Anchor = AnchorStyles.None
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(84, 288)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(22, 21)
        CheckBox2.TabIndex = 7
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.Anchor = AnchorStyles.None
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(84, 404)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(22, 21)
        CheckBox3.TabIndex = 8
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.Anchor = AnchorStyles.None
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(84, 539)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(22, 21)
        CheckBox4.TabIndex = 9
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Location = New Point(317, 151)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 46)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Location = New Point(317, 271)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(326, 46)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.None
        TextBox3.Location = New Point(317, 398)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(326, 46)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.None
        TextBox4.Location = New Point(317, 526)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(326, 46)
        TextBox4.TabIndex = 13
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Font = New Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button2.Location = New Point(293, 677)
        Button2.Name = "Button2"
        Button2.Size = New Size(212, 77)
        Button2.TabIndex = 14
        Button2.Text = "検索"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Kensaku
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(803, 803)
        Controls.Add(Button2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Name = "Kensaku"
        Text = "Kensaku"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
End Class
