<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
    <?php
    if(isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
        $x = $_GET['num1'];
        $y = $_GET['num2'];
        $z = $_GET['num3'];

        if(isZero($x) || isZero($y) || isZero($z)){
            echo 'Positive';
        }
        else{
            $negativeCount = 0;

            if(isPositive($x))
                $negativeCount++;
            if(isPositive($y))
                $negativeCount++;
            if(isPositive($z))
                $negativeCount++;

            if($negativeCount % 2 != 0){
                echo 'Positive';
            }
            else{
                echo 'Negative';
            }
        }
    }

    function isZero($n){
        if(substr($n, 0, 1) === '0'){
            return true;
        }

        return false;
    }

    function isPositive($n){
        if (substr($n, 0, 1) === '-'){
            return false;
        }

        return true;
    }
    ?>
</body>
</html>