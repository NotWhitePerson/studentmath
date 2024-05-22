"use server";

import axios from "axios";

export async function updateAction(formData: FormData, id: number) {
    try {
        const result = await axios.put(`https://dummy.restapiexample.com/api/v1/update/${id}`, {
            name  : formData.get("name"),
            age   : formData.get("age"),
            salary: formData.get("salary"),
        })

        if (result.status === 200) {
            return true;
        }
        return false
    } catch (err) {
        return false
    }
}
