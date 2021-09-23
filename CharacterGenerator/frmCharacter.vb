'Author: Casey Bement
'Date: 09/23/2021
'Purpose: Create a basic random character generator for a typical role-playing game.

Option Strict On
Option Explicit On
Public Class frmCharacter

    'Class Level List
    Dim lstStats As New List(Of Integer)
    Dim rndNumberGen As New Random()
    Private Sub btnRandonName_Click(sender As Object, e As EventArgs) Handles btnRandonName.Click

        ' Create two Lists
        Dim lstNamePrefix As New List(Of String)
        Dim lstNameSuffix As New List(Of String)

        ' Create Variables
        Dim strName As String

        'Create Random Numbers
        Dim rndNumberPrefix As New Random()
        Dim rndNumberSuffix As New Random()

        'Populate Name Prefix List
        lstNamePrefix.Add("Ru")
        lstNamePrefix.Add("Al")
        lstNamePrefix.Add("Cu")
        lstNamePrefix.Add("Gar")
        lstNamePrefix.Add("Arun")
        lstNamePrefix.Add("Mal")
        lstNamePrefix.Add("Val")
        lstNamePrefix.Add("Yir")

        'Populate Name Suffix List
        lstNameSuffix.Add("din")
        lstNameSuffix.Add("zin")
        lstNameSuffix.Add("gin")
        lstNameSuffix.Add("kin")
        lstNameSuffix.Add("lin")
        lstNameSuffix.Add("pin")

        'Generate the Name
        strName = lstNamePrefix.Item(rndNumberPrefix.Next(lstNamePrefix.Count)).ToString _
            & lstNameSuffix.Item(rndNumberSuffix.Next(lstNameSuffix.Count)).ToString

        'Output Name
        txtName.Text = strName


    End Sub

    Private Sub frmCharacter_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Populate the Race COmbobox
        cboRace.Items.Add("Human")
        cboRace.Items.Add("Elf")
        cboRace.Items.Add("Dwarf")
        cboRace.Items.Add("Gnome")

        'Selects the first Race
        cboRace.SelectedIndex = 0
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        'Clear lstStats
        lstStats.Clear()

        'Generate Stats
        For intCount = 1 To 6
            lstStats.Add(RollDice(6, 4, True))
        Next

        'lstStats.Add(RollDice(6, 4, True)) as STR
        'lstStats.Add(RollDice(6, 4, True)) as INT
        'lstStats.Add(RollDice(6, 4, True)) as WIS
        'lstStats.Add(RollDice(6, 4, True)) as DEX
        'lstStats.Add(RollDice(6, 4, True)) as CON
        'lstStats.Add(RollDice(6, 4, True)) as CHA

        'Offer Bonuses for Race
        Dim strRace As String = cboRace.SelectedItem.ToString
        If strRace = "Elf" Then
            'Elves get bonus for INT, DEX, CHA
            lstStats(1) += 2
            lstStats(3) += 1
            lstStats(5) += 1
        ElseIf strRace = "Dwarf" Then
            'Dwarf gets bonus to STR, CON, CHA -1
            lstStats(0) += 2
            lstStats(4) += 1
            lstStats(5) -= 1
        ElseIf strRace = "Gnome" Then
            'Dwarf gets bonus to INT, WIS, STR -2
            lstStats(1) += 1
            lstStats(2) += 1
            lstStats(0) -= 2

        End If

        Call DisplayStats()

    End Sub

    Private Function RollDice(intSides As Integer, intNumber As Integer, blnDropLow As Boolean) As Integer
        'Create a List of Die Rolls
        Dim lstDieRolls As New List(Of Integer)

        'Roll each Die
        For intCounter As Integer = 1 To intNumber
            lstDieRolls.Add(rndNumberGen.Next(1, intSides + 1))
        Next

        If blnDropLow Then
            ''Test the die rolls
            'For Each intNum As Integer In lstDieRolls
            '    MessageBox.Show(intNum.ToString)
            'Next
            'MessageBox.Show("Lowest die roll is " & lstDieRolls.Min.ToString)

            Dim intMinValue As Integer = lstDieRolls.Min
            lstDieRolls.Remove(intMinValue)
            Return lstDieRolls.Sum
        Else
            Return lstDieRolls.Sum
        End If
    End Function

    Private Sub DisplayStats()
        'Output Stats 
        lblSTR.Text = lstStats(0).ToString
        lblINT.Text = lstStats(1).ToString
        lblWIS.Text = lstStats(2).ToString
        lblDEX.Text = lstStats(3).ToString
        lblCON.Text = lstStats(4).ToString
        lblCHA.Text = lstStats(5).ToString
    End Sub
End Class
