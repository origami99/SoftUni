<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if(isset($_GET['num'])){
        $n = intval($_GET['num']);

        if ($n === 1){
            echo 1;
        }
        else if($n === 2){
            echo '1 1';
        }
        else {
            $fibArr = [1, 1, 2];

            for ($i = 0; $i < $n - 3; $i++) {
                $first = $fibArr[count($fibArr) - 3];
                $second = $fibArr[count($fibArr) - 2];
                $third = $fibArr[count($fibArr) - 1];

                array_push($fibArr, ($first + $second + $third));
            }

            echo implode(' ', $fibArr);
        }
    }
    ?>
</body>
</html>