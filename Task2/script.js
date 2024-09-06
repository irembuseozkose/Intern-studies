var birinciMatris=[],ikinciMatris=[],sonucMatris=[];
document.addEventListener('DOMContentLoaded',(event)=>{
    
    const button=document.getElementById('btn')
    button.addEventListener('click', () =>{
        matrisInput();
        mul();
        console.log(birinciMatris);
        console.log(ikinciMatris);
        console.log(sonucMatris);
    }); 
});

  function matrisInput()
  {
      for(let i=0;i<3;i++)
      {
          birinciMatris[i]=[];
          ikinciMatris[i]=[];
          for(let j=0;j<3;j++)
          {
              birinciMatris[i][j]=document.getElementById(`m${i}${j}`).value||0;
              ikinciMatris[i][j]=document.getElementById(`n${i}${j}`).value||0;
          }
      }
  }
  function mul()
  {
    for(let i=0;i<3;i++)
    {
        sonucMatris[i]=[]
        for(let j=0;j<3;j++)
        {
            sonucMatris[i][j]=0;
            for(let k=0;k<3;k++)
            {
                sonucMatris[i][j]=sonucMatris[i][j]+birinciMatris[i][k]*ikinciMatris[k][j];
            }
            
        }
    }
    for(let i=0;i<3;i++)
        {
            for(let j=0;j<3;j++)
            {
                document.getElementById(`s${i}${j}`).innerHTML= sonucMatris[i][j];
            }
        }
    
  }
