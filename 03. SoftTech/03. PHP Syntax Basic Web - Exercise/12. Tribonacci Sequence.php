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
            $fib_arr = [1, 1, 2];

            for ($i = 0; $i < $n - 3; $i++) {
                $first = $fib_arr[count($fib_arr) - 3];
                $second = $fib_arr[count($fib_arr) - 2];
                $third = $fib_arr[count($fib_arr) - 1];

                array_push($fib_arr, ($first + $second + $third));
            }

            echo implode(' ', $fib_arr);
        }
    }
    ?>
</body>
</html>