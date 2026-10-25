import type { CatalogItem } from "./types";

export async function getCatalogItems(): Promise<CatalogItem[]>{
    const response = await fetch("/api/catalog");

    if(!response.ok){
        throw new Error(`Failed to load catalog item: ${response.status}`);
    }

    return response.json();
}