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
        else {
            $fib_arr = [1, 1];

            for ($i = 0; $i < $n - 2; $i++) {
                $first = $fib_arr[count($fib_arr) - 2];
                $second = $fib_arr[count($fib_arr) - 1];

                array_push($fib_arr, ($first + $second));
            }

            echo implode(' ', $fib_arr);
        }
    }
    ?>
</body>
</html>