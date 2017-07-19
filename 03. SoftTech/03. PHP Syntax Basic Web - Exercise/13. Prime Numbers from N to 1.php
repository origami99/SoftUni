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

        $PrimeNums = array();

        for($i = 2; $i <= $n; $i++){

            $isPrime = true;
            for($j = 2; $j <= $i; $j++){
                if($i % $j === 0 && $i !== $j){
                    $isPrime = false;
                    break;
                }
            }

            if($isPrime){
                array_push($PrimeNums, $i);
            }
        }

        $PrimeNums = array_reverse($PrimeNums);

        foreach($PrimeNums as $num){
            echo "$num ";
        }
    }
    ?>
</body>
</html>