<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <title>First Steps Into PHP</title>
        <style>
            div {
                display: inline-block;
                margin: 5px;
                width: 20px;
                height: 20px;
            }
        </style>
    </head>
    <body>
    <?php
    for($row = 0; $row < 5; $row++) {
        $shade = 51 * $row;

        for ($col = 0; $col < 10; $col++) {
            echo "<div style='background-color: rgb($shade, $shade, $shade)'></div>";
            $shade += 5;
        }

        echo "<br>";
    }
    ?>
    </body>
</html>