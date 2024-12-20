'mysqlへ接続するのに必要なコード...だと思う。
Imports System.Drawing.Design
Imports System.Net.Mail
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Touroku
    Dim connectionString As String = "Server=localhost;Database=ProjectC;User ID=root;Password=root;Pooling=true;"
    Dim connection As New MySqlConnection(connectionString)
    Dim currentpage As Integer = 1
    Dim rowperpage As Integer = 10
    Dim maxpage As Integer
    Dim count As Integer

    'メイン画面へ戻る
    Private Sub btn_mainback_Click(sender As Object, e As EventArgs) Handles btn_mainback.Click
        Me.Close()
    End Sub

    '顧客登録処理
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_signup.Click

        'Dim変数名をつけていますよ
        Dim FirstName As String = TextBox1.Text
        Dim LastName As String = TextBox2.Text
        Dim MailAddres As String = TextBox3.Text
        Dim PhoneNumber As String = TextBox4.Text
        Dim Prefecture As String = TextBox5.Text
        Dim City As String = TextBox6.Text
        Dim StreetName As String = TextBox7.Text
        Dim BlockNumber As String = TextBox8.Text
        Dim Building As String = TextBox9.Text
        Dim RoomNumber As String = TextBox10.Text
        Dim Gender As String = TextBox11.Text
        Dim Point As Integer
        If Integer.TryParse(TextBox12.Text, Point) = False Then
            Point = 0 ' デフォルト値を0に設定
        End If


        connection.Open()
        Try
            Dim query As String = "INSERT INTO customermaster (last_name, first_name, email, phone_num, prefecture, city, street_name, block_num, building_name, room_num, gender, points )
            VALUES (@FirstName, @LastName, @MailAddres, @PhoneNumber , @Prefecture, @City , @StreetName, @BlockNumber, @Building,@RoomNumber, @Gender, @Point)"

            Dim Command As New MySqlCommand(query, connection)

            'パラメーターを設定してる
            Command.Parameters.AddWithValue("@FirstName", FirstName)
            Command.Parameters.AddWithValue("@LastName", LastName)
            Command.Parameters.AddWithValue("@MailAddres", MailAddres)
            Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber)
            Command.Parameters.AddWithValue("@Prefecture", Prefecture)
            Command.Parameters.AddWithValue("@City", City)
            Command.Parameters.AddWithValue("@StreetName", StreetName)
            Command.Parameters.AddWithValue("@BlockNumber", BlockNumber)
            Command.Parameters.AddWithValue("@Building", Building)
            Command.Parameters.AddWithValue("@RoomNumber", RoomNumber)
            Command.Parameters.AddWithValue("@Gender", Gender)
            Command.Parameters.AddWithValue("@Point", Point)
            'sqlコマンドを実行
            Dim rowsAffected As Integer = Command.ExecuteNonQuery()
            MessageBox.Show($"{rowsAffected} 件のデータが登録されました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)


            MessageBox.Show("登録が成功しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Dim command As New MySqlConnection("INSERT INTO customermaster ")


        Catch ex As Exception
            ' エラー内容を表示
            MessageBox.Show($"データベースエラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"エラーが発生しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'gridviewに表示
    Private Sub Loadgridview()
        Dim command As New MySqlCommand()
        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "CustomerAll"
        command.Parameters.AddWithValue("@pageNumber", currentpage)
        command.Parameters.AddWithValue("@pageSize", rowperpage)


        Dim com As New DataSet
        Dim adapter As New MySqlDataAdapter(command)
        adapter.SelectCommand = command

        adapter.Fill(com)
        DataGridView1.DataSource = com.Tables(1)
        count = com.Tables(0).Rows(0)(0)
        maxpage = Math.Ceiling(count / rowperpage)

    End Sub

    'ヘッダの編集変更不可
    Private Sub DisableSorting()
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    'ページング機能の実施
    Private Sub Touroku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadgridview()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentpage < maxpage Then
            currentpage += 1
        End If
        'TextBox13.Text = currentpage
        'Loadgridview()
        Call Loadgridview()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If currentpage > 1 Then
            currentpage -= 1
        End If
        Call Loadgridview()
        'TextBox13.Text = currentpage
    End Sub
End Class