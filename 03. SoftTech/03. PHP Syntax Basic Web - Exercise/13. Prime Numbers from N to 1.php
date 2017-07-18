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

        $prime_nums = array();

        for($i = 2; $i <= $n; $i++){

            $is_prime = true;
            for($j = 2; $j <= $i; $j++){
                if($i % $j === 0 && $i !== $j){
                    $is_prime = false;
                    break;
                }
            }

            if($is_prime){
                array_push($prime_nums, $i);
            }
        }

        $prime_nums = array_reverse($prime_nums);

        foreach($prime_nums as $num){
            echo "$num ";
        }
    }
    ?>
</body>
</html>