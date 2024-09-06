var secretNum;
var correct,wrongPlace;
console.log(generateNum());
document.addEventListener('DOMContentLoaded', (event) => {
   
    const button = document.getElementById('btn');
    const textbox = document.getElementById('selectedNum');
    const resultDiv =document.getElementById("result");


    button.addEventListener('click', () => {
        
        var textboxValue = textbox.value;
        var textboxArray = digitCalc(parseInt(textboxValue));
        correct=0,wrongPlace=0;
        if (!isNaN(textboxValue) && textboxValue.length === 6) { 
            digitCheck(textboxArray, secretNum);
            if (correct === 6) {
                document.getElementById("resultText").innerHTML= "Kazandınız! Sayı: " + secretNum.join('');
                secretNum = generateNum(); 
                document.getElementById("newNum").innerHTML=("Yeni Gizli Numara: " + secretNum.join(''));
            }
        } else {
            alert("6 haneli bir sayı giriniz.");
        }
        
        
    
    
    });
});

function deleteMem(array, i) {
    let newArray = []; 
    let k = 0; 
    for (let j = 0; j < array.length; j++) 
    {
        if (j !== i) 
        { 
            newArray[k] = array[j];
            k++; 
        }
    }
    return newArray; 
}

function generateNum()
{
    secretNum=[], control=false,selectDig=[0,1,2,3,4,5,6,7,8,9];


    for(let i=0;i<6;i++)
    {
        let randomIndex= Math.floor(Math.random()*(selectDig.length));

        secretNum[i]=selectDig[randomIndex];

        selectDig = deleteMem(selectDig,randomIndex);
        if  (secretNum[0]==0)
            {
                i--;
                secretNum=deleteMem(secretNum,0);
                selectDig.push(0);
            }
    }
    return secretNum;
    
}

function digitCalc(number) 
{
    let array = [];

    for (let i = 5 ; i>=0 ; i--) {
      array[i] = Math.floor(number % 10);
      number = number/ 10;
    }

    return array;
}

function digitCheck(refArray,array)
{
    let checked1 = new Array(refArray.length).fill(false);
    let checked2 = new Array(array.length).fill(false);
    for(let i=0;i<refArray.length;i++)
    {
        if(refArray[i]===array[i])
        {
            correct++;
            checked1[i]=true;
            checked2[i]=true;
        }
    }

    for(let i=0;i<refArray.length;i++)
     {
        if(!checked1[i])
        {
            for(let j=0;j<refArray.length;j++)
            {
                if(!checked2[j])
                {
                    if(refArray[i]===array[j])
                    {
                        wrongPlace++;
                        checked2[j]=true;
                        break;
                    }
                }
            }
        }
     }
    console.log("Doğru yerdekiler: "+ correct + "\n" + "Doğru sayı olup yanlış yerdekiler" + wrongPlace);
    document.getElementById("correctNum").innerHTML=correct;
    
    document.getElementById("wrongPlace").innerHTML=wrongPlace;
}
