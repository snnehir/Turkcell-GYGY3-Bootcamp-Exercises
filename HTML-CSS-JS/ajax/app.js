/*
AJAX (Asynchronous JavaScript and XML) is a technology that allows web pages to 
exchange data in the background, without requiring the page to be reloaded. 

This makes web pages faster and more responsive, providing users with a better 
and more interactive experience. 
*/

async function getStarwarsDataFromAPI() {
    const url = "https://swapi.dev/api/films"

    /*fetch(url).then(res => {
        console.log(res)
    })*/
    const div = document.getElementById("films")
    let response = await fetch(url)
    if (response.ok) {
        let resultJson = await response.json()
        let films = resultJson.results
        for (let i = 0; i < films.length; i++) {
            let film = films[i]
            let p = document.createElement('p');
            div.appendChild(p);
            p.innerHTML = film.title;
        }
    } else {
        console.log("Error: ", response.status)
    }

}

// with jQuery
$(document).ready(function () {
    const url = "https://swapi.dev/api/films"
    const div = document.getElementById("filmsJq")
    $("#jq").on("click", function () {
        $.ajax({
            url: url,
            type: "GET",
            // success and error CALLBACKS 
            success: function (response) {
                let films = response.results
                for (let i = 0; i < films.length; i++) {
                    let film = films[i]
                    console.log(film.title)
                    let p = document.createElement('p');
                    div.appendChild(p);
                    p.innerHTML = film.title;
                }
            },
            error:function(err){
                console.log(err)
            }
        })
    })
})

function test(successCallback, errorCallback){
    let isSuccess = true
    if(isSuccess){
        successCallback()
    }
    else{
        errorCallback()
    }
}

// functions as parameters
test(function(){
    console.log("Başarılı")
}, ()=>console.log("Hata"))


let promise = new Promise((resolve, reject)=>{/*...*/})
                .then((result)=>console.log("OK"), (err) => console.log("Error")
)

// Promise finished: .then( /* code */ )
// Promise rejected: .catch( /* code */ )