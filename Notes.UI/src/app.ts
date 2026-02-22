const apiUrl = "http://127.0.0.1:39323/api/notes";


interface Note {
    id: string;
    title: string;
    content: string;
    createdAt: string;

}

async function loadNotes() {
    const response = await fetch(apiUrl);
    const notes: Note[] = await response.json();
    const list = document.getElementById("noteList") as HTMLUListElement;
    list.innerHTML = "";

    notes.forEach(note => {
        const li = document.createElement("li");
        li.innerText = `${note.title} - ${note.content}`;
        list.appendChild(li);
    });
}

async function createNote() {
    const titleInput = document.getElementById("title") as HTMLInputElement;
    const contentInput = document.getElementById("content") as HTMLTextAreaElement;

    const note = {
        title: titleInput.value,
        content: contentInput.value
    };

    await fetch(apiUrl, {
        method: "POST",
        headers: {
            "content-type": "application/json"
        },
        body: JSON.stringify(note)
    });
    titleInput.value = "";
    contentInput.value = "";

    loadNotes();
}

window.onload = loadNotes;