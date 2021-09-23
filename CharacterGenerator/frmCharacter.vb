'Author: Casey Bement
'Date: 09/23/2021
'Purpose: Create a basic random character generator for a typical role-playing game.

Option Strict On
Option Explicit On
Public Class frmCharacter
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
End Class
