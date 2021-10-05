'Sebastian Soto
'RCET0265
'Fall 2021
'Diner Menu
'https://github.com/SebastianSotoMk4/DinerMenu.git
Option Strict On
Option Explicit On
Public Class DinerMenuForm


    Private Sub LateNightButton_Click(sender As Object, e As EventArgs) Handles LateNightButton.Click
        menuLabel.Text = "Salami, Capicola, ham, cheese, onion, oil & vinegar and oregano-basil"

    End Sub

    Private Sub TheVisualBasicButton_Click(sender As Object, e As EventArgs) Handles TheVisualBasicButton.Click
        menuLabel.Text = "ham and cheese"

    End Sub

    Private Sub CompileTunaButton_Click(sender As Object, e As EventArgs) Handles CompileTunaButton.Click
        menuLabel.Text = "Tuna salad, double cheese & cucumber (no mayo*)"

    End Sub

    Private Sub VBLTButton_Click(sender As Object, e As EventArgs) Handles VBLTButton.Click

        menuLabel.Text = "Vienna sausages with Bacon Lettuce and tomato, served on freshly baked french bread or whole wheat"

        'MsgBox("Vienna sausages with Bacon Lettuce and tomato")
    End Sub

    Private Sub menuLabel_Click(sender As Object, e As EventArgs) Handles menuLabel.Click
        menuLabel.Text = "food"

    End Sub
End Class
