import axios from "axios";
import { useEffect, useState } from "react"
import IActivity from "./interfaces/IActivity";
import { Header, List } from "semantic-ui-react";

function App() {
  const [activities, setActivities] = useState<IActivity[]>();

  useEffect(() => {
    axios.get("http://localhost:5000/api/Activities")
      .then(res => setActivities(res.data))
      .catch(err => console.log("Error occured", err));
  }, []);

  return (
    <>
      <Header as="h2" icon="users" content="Reactivities" />
      <List>
        {activities?.map(activity => {
          return <List.Item key={activity.id}>{activity.title}</List.Item>
        })}
      </List>
    </>
  )
}

export default App
