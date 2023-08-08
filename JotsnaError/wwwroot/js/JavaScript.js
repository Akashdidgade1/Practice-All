function Calculate()
{
          alert( "How Are You ?");

    var Inutdate = document.getElementById('birthdate').value;
    var text = document.getElementById('txt1').value;
    //Input Birth date
    let birthdate = new Date(Inutdate);

    //getTime : returns the number of milliseconds
    let now = new Date();
    let time = now.getTime();
    let ageInMs = now.getTime() - birthdate.getTime();

    let ageInS = ageInMs / 1000;
    let ageInMins = ageInS / 60;
    let ageInHrs = ageInMins / 60;
    let ageInDays = ageInHrs / 24;
    let ageInMonths = ageInDays / 30.4375;
    let ageInyears = ageInMonths / 12;
/*    var month_diff = Date.now() - birthdate.getTime();  
    var age_dt = new Date(month_diff);   
    var year = age_dt.getUTCFullYear(); 
    var age = Math.abs(year - birthdate); */
/*
    document.querySelector('#years').innerHTML = year;*/
   
    document.querySelector('#years').innerHTML = Math.floor(ageInyears);
    document.querySelector('#months').innerHTML = Math.floor(ageInMonths % 12);
    document.querySelector('#days').innerHTML = Math.floor(ageInDays % 30.4375);
    document.querySelector('#hours').innerHTML = Math.floor(ageInHrs % 24);
    document.querySelector('#minutes').innerHTML = Math.floor(ageInMins % 60);
    document.querySelector('#seconds').innerHTML = Math.floor(ageInS % 60);
    document.querySelector('#seconds').style.borderBottom = '1px grey solid';
    
    

}
function reset() {
    window.location.reload();
}