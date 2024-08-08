
 
const  jsonFilePath =  '/Users/shalom_bergman/kodcode2/IronDomeProject/attackServer/ServerBeckend/missiles.json';


//const missels = JSON.parse(misselsJson)
 async function fetchJSONData() {
 try{
    const response = await fetch(jsonFilePath)       
            if (!response.ok) {
                throw new Error (`HTTP error! Status: ${response.status}`);                   
            }
            const jsonData = await response.json();
            console.log(JSON.stringify(jsonData));

            const jsonDataList = [jsonData];
            return jsonDataList;
        }catch(error) {
            console.error("Unable to fetch data:", error);
        }
 }
        
 fatchJSONData().then(jsonDataList => {
    console.log("Data saved in memory:", jsonDataList);
 });