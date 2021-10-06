'Sebastian Soto
'RCET0265
'Fall 2021
'Diner Menu
'https://github.com/SebastianSotoMk4/DinerMenu.git
Option Strict On
Option Explicit On
Public Class DinerMenuForm


    Private Sub LateNightButton_Click(sender As Object, e As EventArgs) Handles LateNightButton.Click
        menuLabel.Text = "Salami, Capicola, ham, cheese, onion, oil & vinegar and oregano-basil, served on your choice of; Rosemary Chibatta, basil infued wrap or garlic and oregano flatbread"
    End Sub

    Private Sub TheVisualBasicButton_Click(sender As Object, e As EventArgs) Handles TheVisualBasicButton.Click
        menuLabel.Text = "ham and cheese served on a 6Inch Classic french Bread"
    End Sub

    Private Sub CompileTunaButton_Click(sender As Object, e As EventArgs) Handles CompileTunaButton.Click
        menuLabel.Text = "Tuna salad, double cheese & cucumber, served on your choice of Fresh baked french bread, whole wheat or in a pitta pocket "
    End Sub

    Private Sub VBLTButton_Click(sender As Object, e As EventArgs) Handles VBLTButton.Click

        menuLabel.Text = "Vienna sausages with Bacon Lettuce and tomato, served on freshly baked french bread or whole wheat"
    End Sub

    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
