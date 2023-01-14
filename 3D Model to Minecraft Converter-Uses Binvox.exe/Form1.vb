Imports System.ComponentModel

Public Class Form1
    Dim fileSaveLocationBrowseDialog As New FolderBrowserDialog
    Public filePath As String = Nothing

    '
    Dim voxelGridSize As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aboutForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles selectFileBtn.Click
        SelectFileDialogvb.ShowDialog()
    End Sub
    Private Sub SelectExportLocBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles specifyVoxlGrdSizChckBox.CheckedChanged
        If specifyVoxlGrdSizChckBox.Checked = True Then
            voxlGrdSizeNumUpDown.Enabled = True
        ElseIf specifyVoxlGrdSizChckBox.Checked = False Then
            voxlGrdSizeNumUpDown.Enabled = False
        End If


    End Sub
    Dim binvoxCommand As String

    Private Sub ConvertBtn_Click(sender As Object, e As EventArgs) Handles convertBtn.Click


        If filePath = Nothing Then
            MessageBox.Show("Please select a file!", "Conversion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        '
        If ComboBox1.Text = "" Then
            MessageBox.Show("Please select a block!", "Conversion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Voxel grid size
        Dim voxelGridSize As Integer
        Dim rotationX As Integer = Int32.Parse(rotDegreesX.Text.Remove(rotDegreesX.Text.Length - 7).Trim())
        Dim rotationZ As Integer = Int32.Parse(rotDegreesZ.Text.Remove(rotDegreesZ.Text.Length - 7).Trim())
        voxelGridSize = voxlGrdSizeNumUpDown.Value
        Dim remInternalVoxls As String
        If CheckBox1.Checked = True Then
            remInternalVoxls = " -ri"
        ElseIf CheckBox1.Checked = False Then
            remInternalVoxls = ""
        End If
        '

        'Set the block
        Dim blockID As String
        Select Case ComboBox1.Text.ToLower.Trim
            Case "stone"
                blockID = 1
            Case "granite"
                blockID = "1:1"
            Case "polished granite"
                blockID = "1:2"
            Case "diorite"
                blockID = "1:3"
            Case "polished diorite"
                blockID = "1:4"
            Case "andesite"
                blockID = "1:5"
            Case "polished andesite"
                blockID = "1:6"
            Case "grass"
                blockID = 2
            Case "dirt"
                blockID = 3
            Case "cobblestone"
                blockID = 4
            Case "oak wood plank"
                blockID = 5
            Case "spruce wood plank"
                blockID = "5:1"
            Case "birch wood plank"
                blockID = "5:2"
            Case "jungle wood plank"
                blockID = "5:3"
            Case "acacia wood plank"
                blockID = "5:4"
            Case "dark oak wood plank"
                blockID = "5:5"
            Case "bedrock"
                blockID = 7
            Case "still water"
                blockID = 9
            Case "still lava"
                blockID = 11
            Case "sand"
                blockID = 12
            Case "red sand"
                blockID = "12:1"
            Case "gravel"
                blockID = 13
            Case "gold ore"
                blockID = 14
            Case "iron ore"
                blockID = 15
            Case "coal ore"
                blockID = 16
            Case "oak wood"
                blockID = 17
            Case "spruce wood"
                blockID = "17:1"
            Case "birch wood"
                blockID = "17:2"
            Case "jungle wood"
                blockID = "17:3"
            Case "oak leaves"
                blockID = 18
            Case "spruce leaves"
                blockID = "18:1"
            Case "birch leaves"
                blockID = "18:2"
            Case "jungle leaves"
                blockID = "18:3"
            Case "sponge"
                blockID = 19
            Case "glass"
                blockID = 20
            Case "lapis lazuli ore"
                blockID = 21
            Case "lapis lazuli block"
                blockID = 22
            Case "dispenser"
                blockID = 23
            Case "sandstone"
                blockID = 24
            Case "chiseled sandstone"
                blockID = "24:1"
            Case "smooth sandstone"
                blockID = "24:2"
            Case "note block"
                blockID = 25
            Case "sticky piston"
                blockID = 29
            Case "cobweb"
                blockID = 30
            Case "piston"
                blockID = 33
            Case "white wool"
                blockID = 35
            Case "orange wool"
                blockID = "35:1"
            Case "magenta wool"
                blockID = "35:2"
            Case "light blue wool"
                blockID = "35:3"
            Case "yellow wool"
                blockID = "35:4"
            Case "lime wool"
                blockID = "35:5"
            Case "pink wool"
                blockID = "35:6"
            Case "gray wool"
                blockID = "35:7"
            Case "light gray wool"
                blockID = "35:8"
            Case "cyan wool"
                blockID = "35:9"
            Case "purple wool"
                blockID = "35:10"
            Case "blue wool"
                blockID = "35:11"
            Case "brown wool"
                blockID = "35:12"
            Case "green wool"
                blockID = "35:13"
            Case "red wool"
                blockID = "35:14"
            Case "black wool"
                blockID = "35:15"
            Case "gold block"
                blockID = 41
            Case "iron block"
                blockID = 42
            Case "double stone slab"
                blockID = 43
            Case "stone slab"
                blockID = 44
            Case "bricks"
                blockID = 45
            Case "tnt"
                blockID = 46
            Case "bookshelf"
                blockID = 47
            Case "moss stone"
                blockID = 48
            Case "obsidian"
                blockID = 49
            Case "monster spawner"
                blockID = 52
            Case "oak wood stairs"
                blockID = 53
            Case "chest"
                blockID = 54
            Case "diamond ore"
                blockID = 56
            Case "diamond block"
                blockID = 57
            Case "crafting table"
                blockID = 58
            Case "furnace"
                blockID = 61
            Case "cobblestone stairs"
                blockID = 67
            Case "redstone ore"
                blockID = 73
            Case "ice"
                blockID = 79
            Case "snow block"
                blockID = 80
            Case "clay"
                blockID = 82
            Case "jukebox"
                blockID = 84
            Case "pumpkin"
                blockID = 86
            Case "netherrack"
                blockID = 87
            Case "soul sand"
                blockID = 88
            Case "glowstone"
                blockID = 89
            Case "white stained glass"
                blockID = 95
            Case "orange stained glass"
                blockID = "95:1"
            Case "magenta stained glass"
                blockID = "95:2"
            Case "light blue stained glass"
                blockID = "95:3"
            Case "yellow stained glass"
                blockID = "95:4"
            Case "lime stained glass"
                blockID = "95:5"
            Case "pink stained glass"
                blockID = "95:6"
            Case "gray stained glass"
                blockID = "95:7"
            Case "light gray stained glass"
                blockID = "95:8"
            Case "cyan stained glass"
                blockID = "95:9"
            Case "purple stained glass"
                blockID = "95:10"
            Case "blue stained glass"
                blockID = "95:11"
            Case "brown stained glass"
                blockID = "95:12"
            Case "green stained glass"
                blockID = "95:13"
            Case "red stained glass"
                blockID = "95:14"
            Case "black stained glass"
                blockID = "95:15"
            Case "stone monster egg"
                blockID = 97
            Case "cobblestone monster egg"
                blockID = "97:1"
            Case "stone brick monster egg"
                blockID = "97:2"
            Case "mossy stone brick monster egg"
                blockID = "97:3"
            Case "cracked stone brick monster egg"
                blockID = "97:4"
            Case "chiseled stone brick monster egg"
                blockID = "97:5"
            Case "stone bricks"
                blockID = 98
            Case "mossy stone bricks"
                blockID = "98:1"
            Case "cracked stone bricks"
                blockID = "98:2"
            Case "chiseled stone bricks"
                blockID = "98:3"
            Case "brown mushroom block"
                blockID = 99
            Case "red mushroom block"
                blockID = 100
            Case "melon block"
                blockID = 103
            Case "brick stairs"
                blockID = 108
            Case "stone brick stairs"
                blockID = 109
            Case "mycelium"
                blockID = 110
            Case "nether brick"
                blockID = 112
            Case "end stone"
                blockID = 121
            Case "redstone lamp"
                blockID = 123
            Case "oak wood slab"
                blockID = 126
            Case "sandstone stairs"
                blockID = 128
            Case "emerald ore"
                blockID = 129
            Case "ender chest"
                blockID = 130
            Case "emerald block"
                blockID = 133
            Case "spruce wood stairs"
                blockID = 134
            Case "birch wood stairs"
                blockID = 135
            Case "jungle wood stairs"
                blockID = 136
            Case "command block"
                blockID = 137
            Case "beacon"
                blockID = 128
            Case "oak fence"
                blockID = 85
            Case "nether brick fence"
                blockID = 113
            Case "cobblestone wall"
                blockID = 139
            Case "quartz block"
                blockID = 155
            Case "chiseled quartz block"
                blockID = "155:1"
            Case "pillar quartz block"
                blockID = "155:2"
            Case "quartz stairs"
                blockID = 156
            Case "dropper"
                blockID = 158
            Case "white hardened clay"
                blockID = 159
            Case "orange hardened clay"
                blockID = "159:1"
            Case "magenta hardened clay"
                blockID = "159:2"
            Case "light blue hardened clay"
                blockID = "159:3"
            Case "yellow hardened clay"
                blockID = "159:4"
            Case "lime hardened clay"
                blockID = "159:5"
            Case "pink hardened clay"
                blockID = "159:6"
            Case "gray hardened clay"
                blockID = "159:7"
            Case "light gray hardened clay"
                blockID = "159:8"
            Case "cyan hardened clay"
                blockID = "159:9"
            Case "purple hardened clay"
                blockID = "159:10"
            Case "blue hardened clay"
                blockID = "159:11"
            Case "brown hardened clay"
                blockID = "159:12"
            Case "green hardened clay"
                blockID = "159:13"
            Case "red hardened clay"
                blockID = "159:14"
            Case "black hardened clay"
                blockID = "159:15"
            Case "acacia leaves"
                blockID = 161
            Case "dark oak leaves"
                blockID = "161:1"
            Case "acacia wood"
                blockID = 162
            Case "dark oak wood"
                blockID = "162:1"
            Case "acacia wood stairs"
                blockID = 163
            Case "dark oak wood stairs"
                blockID = 164
            Case "slime block"
                blockID = 165
            Case "barrier"
                blockID = 166
            Case "prismarine"
                blockID = 168
            Case "sea lantern"
                blockID = 169
            Case "hay bale"
                blockID = 170
            Case "hardened clay"
                blockID = 172
            Case "block of coal"
                blockID = 173
            Case "red sandstone"
                blockID = 179
            Case "red sandstone slab"
                blockID = 182
            Case "red sandstone stairs"
                blockID = 180
        End Select
        '
        Dim exactVoxl As String = ""
        If exactVoxlChckBox.Checked = True Then
            exactVoxl = " -e"
        End If

        Dim finalRotationArg As String = ""
        Dim iX As Integer
        Dim iZ As Integer
        iX = rotationX / 90
        iZ = rotationZ / 90
        For i As Integer = 0 To iX - 1
            finalRotationArg += " -rotx"
        Next
        For i As Integer = 0 To iZ - 1
            finalRotationArg += " -rotz"
        Next

        'Create the argument
        binvoxCommand = filePath & " -d " & voxelGridSize & remInternalVoxls & exactVoxl & finalRotationArg & " -t schematic" & " -bi " & blockID
        MessageBox.Show(binvoxCommand)

        'start binvox
        'check if binvox.exe exists
        If Not IO.File.Exists("binvox.exe") Then
            ' MessageBox.Show("binvox.exe is missing!Program cannot start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Application.Exit()
            Try
                'write file
                Using sCreateEXEFile As New IO.FileStream(Application.StartupPath & "\binvox.exe", IO.FileMode.Create)

                    sCreateEXEFile.Write(My.Resources.binvox, 0, My.Resources.binvox.Length)

                End Using
            Catch ex As Exception
                MessageBox.Show("A disk write error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try
        End If
        '

        cmdOutPutTxtBox.Visible = True
        CMD.StartInfo.FileName = "binvox.exe"
        CMD.StartInfo.Arguments = binvoxCommand
        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardInput = True
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = True
        Try
            CMD.Start()
        Catch ex As Exception
            MessageBox.Show("Converter failed to start!", "Conversion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
        commandTxtBoxUpdator.Enabled = True
        commandTxtBoxUpdator.Start()
        'disable groupboxes
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False


    End Sub
    Dim CMD As New Process
    Dim outputLastLine As String
    Private Sub CommandTxtBoxUpdator_Tick(sender As Object, e As EventArgs) Handles commandTxtBoxUpdator.Tick
        Try
            Dim SW As System.IO.StreamWriter = CMD.StandardInput
            Dim SR As System.IO.StreamReader = CMD.StandardOutput

            cmdOutPutTxtBox.Text = SR.ReadToEnd
            cmdOutPutTxtBox.SelectionStart = cmdOutPutTxtBox.Text.Length + 1

            'check if binvox has exited
            If CMD.HasExited Then
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
                commandTxtBoxUpdator.Enabled = False
                cmdOutPutTxtBox.Text = cmdOutPutTxtBox.Text.Trim
                outputLastLine = cmdOutPutTxtBox.Lines(cmdOutPutTxtBox.Lines.Length - 1)
                If outputLastLine = "done" Then
                    MessageBox.Show("Done! You can use MCEdit or any other tool to implement this structure into your minecraft world!", "Conversion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf cmdOutPutTxtBox.Text.Contains("Error: mesh has no polygons") Then
                    MessageBox.Show("Error: mesh has no polygons.Please select a valid 3D Model", "Invalid 3D Model", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf cmdOutPutTxtBox.Text.Contains("error: could not find the file") Then
                    MessageBox.Show(outputLastLine.Trim() + Environment.NewLine + "Make sure there are no spaces in the file's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                GroupBox3.Enabled = False
            End If
        Catch ex As Exception
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            IO.Directory.CreateDirectory(Application.StartupPath & "\3D_Models")
        Catch ex As Exception
            MessageBox.Show("Error. Could not create 3D_Models folder. Closing...")
            Application.Exit()
        End Try

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            IO.File.Delete(Application.StartupPath & "\binvox.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/channel/UC2gbJXjFTHsQWGNVfXFN1Ig")
    End Sub
    Private Sub setDegrees(deg As Integer, txtbox As TextBox)
        Dim degrees As Integer = Int32.Parse(txtbox.Text.Remove(txtbox.Text.Length - 7).Trim())
        If degrees = 360 And deg > 0 Then
        ElseIf degrees = 0 And deg < 0 Then
        Else
            txtbox.Text = degrees + deg & " degrees"
        End If
    End Sub

    Private Sub rotR_Click(sender As Object, e As EventArgs) Handles rotRZ.Click
        setDegrees(90, rotDegreesZ)
    End Sub

    Private Sub rotL_Click(sender As Object, e As EventArgs) Handles rotLZ.Click
        setDegrees(-90, rotDegreesZ)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles rotLX.Click
        setDegrees(-90, rotDegreesX)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles rotRX.Click
        setDegrees(90, rotDegreesX)
    End Sub

    Private Sub Form1_CursorChanged(sender As Object, e As EventArgs) Handles MyBase.CursorChanged

    End Sub
End Class
