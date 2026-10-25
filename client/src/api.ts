import type { CatalogItem, GarageItem } from "./types";

export async function getCatalogItems(): Promise<CatalogItem[]>{
    const response = await fetch("/api/catalog");

    if(!response.ok){
        throw new Error(`Failed to load catalog item: ${response.status}`);
    }

    return response.json();
}

export async function addToGarage(vehicleGameId: number): Promise<GarageItem>{
    const response = await fetch ('/api/garage', {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({vehicleGameId})

    });

    if(!response.ok){
        throw new Error(`Failed to add garage item: ${response.status}`);
    }

    return response.json();
}