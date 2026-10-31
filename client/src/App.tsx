import Catalog from "./components/Catalog";
import Garage from "./components/Garage";
import type { GarageItem } from "./types";
import { useState, useEffect } from "react";
import { getGarage } from "./api";
import "./App.css";

function App() {
  const [garageItems, setGarageItems] = useState<GarageItem[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    async function load() {
      try {
        const myGarage = await getGarage();
        setGarageItems(myGarage);
      } catch {
        setError("Failed to load garage. Is the API running?");
      } finally {
        setLoading(false);
      }
    }
    load();
  }, []);

  function handleAdded(garageItem: GarageItem) {
    console.log(`Garage item added: ${garageItem.vehicleName}`);
  }

  function handleRemoved(garageItemId: number) {
    setGarageItems(garageItems.filter((i) => i.garageItemId !== garageItemId));
  }

  return (
    <>
      <Catalog onAdded={handleAdded} />
      <Garage
        items={garageItems}
        loading={loading}
        error={error}
        onRemoved={handleRemoved}
      />
    </>
  );
}

export default App;
