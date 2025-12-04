        function btnOk(){
            let n = parseInt(document.getElementById("txtN").value, 10);
            
            const d1 = document.getElementById("div01");
            d1.innerHTML = "";
            for(let i = 1; i<=n; i++){
                for(let j=1; j<=i; j++){
                    d1.innerHTML += "*";
                }   
                d1.innerHTML += "<br>";
            }
        }