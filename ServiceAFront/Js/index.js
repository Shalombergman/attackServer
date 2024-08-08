
const misseles = []
const addMissile = () => {      
    const missilesDiv = document.getElementById("missiles-div")
    const p = document.createElement("p");
    p.innerText = misseles.shift();
    missilesDiv.appendChild(p);  
}

let missiles;
const loadMissilesJson = async() => {
    const response = await fetch(jsonFilePath);
    const jsonData = await response.json();    
    //console.log(`result is : ${JSON.stringify(jsonDataList)}`)
    return jsonData;
    
}
var jsonData = await loadMissilesJson();
var jsonDataList = [];


    

console.log(jsonDataList);

const  jsonFilePath =  '/ServiceAFront/Html/missiles.json';


//const missels = JSON.parse(misselsJson)
//  async function fetchJSONData() {
//  try{
//     const response = await fetch(jsonFilePath)       
//             if (!response.ok) {
//                 throw new Error (`HTTP error! Status: ${response.status}`);                   
//             }
//             const jsonData = await response.json();
//             console.log(JSON.stringify(jsonData));

//             const jsonDataList = [jsonData];
//             return jsonDataList;
//         }catch(error) {
//             console.error("Unable to fetch data:", error);
//         }
//  }
        
 