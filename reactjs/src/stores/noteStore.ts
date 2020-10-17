import { action, observable } from 'mobx';

import CreateNoteInput from '../services/note/dto/createNoteInput';
import { EntityDto } from '../services/dto/entityDto';
import { GetAllNoteOutput } from '../services/note/dto/getAllNoteOutput';
import { PagedResultDto } from '../services/dto/pagedResultDto';
import { PagedNoteResultRequestDto } from '../services/note/dto/PagedNoteResultRequestDto';
import NoteModel from '../models/Notes/NoteModel';
import UpdateNoteInput from '../services/note/dto/updateNoteInput';
import noteService from '../services/note/noteService';

class NoteStore {
    @observable notes!: PagedResultDto<GetAllNoteOutput>;
    @observable noteModel: NoteModel = new NoteModel();

    @action
    async create(createNoteInput: CreateNoteInput) {
        await noteService.create(createNoteInput);
    }

    @action
    async createNote() {
        this.noteModel = {
            id: 0,
            title: '',
            text: '',
        };
    }

    @action
    async update(updateNoteInput: UpdateNoteInput) {
        let result = await noteService.update(updateNoteInput);

        this.notes.items = this.notes.items.map((x: GetAllNoteOutput) => {
            if (x.id === updateNoteInput.id) x = result;
            return x;
        });
    }

    @action
    async delete(entityDto: EntityDto) {
        await noteService.delete(entityDto);
        this.notes.items = this.notes.items.filter((x: GetAllNoteOutput) => x.id !== entityDto.id);
    }

    @action
    async get(entityDto: EntityDto) {
        let result = await noteService.get(entityDto);
        this.noteModel = result;
    }

    @action
    async getAll(pagedFilterAndSortedRequest: PagedNoteResultRequestDto) {
        let result = await noteService.getAll(pagedFilterAndSortedRequest);
        this.notes = result;
    }
}

export default NoteStore;
