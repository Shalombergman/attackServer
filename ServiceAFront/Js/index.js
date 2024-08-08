

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
    console.log(`result is : ${JSON.stringify(jsonData)}`)
    return jsonData;
    
}


const JsonDataList = async () => {
    const jsonData = await loadMissilesJson();
    const jsonArray = await JSON.parse(jsonData);
    console.log (jsonArray);
}



    


let i = 0;


const  jsonFilePath =  '/ServiceAFront/Html/missiles.json';
const socket = new WebSocket('ws://localhost:3108/MissileHandler');

async function publishMessage () {
    const missiles =await loadMissilesJson();
  socket.send(JSON.stringify(missiles[i]));
  i++;
}


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
        
 