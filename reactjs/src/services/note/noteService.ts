import CreateNoteInput from './dto/createNoteInput';
import CreateNoteOutput from './dto/createNoteOutput';
import { EntityDto } from '../../services/dto/entityDto';
import { GetAllNoteOutput } from './dto/getAllNoteOutput';
import GetNoteOutput from './dto/getNoteOutput';
import { PagedResultDto } from '../../services/dto/pagedResultDto';
import { PagedNoteResultRequestDto } from './dto/PagedNoteResultRequestDto';
import UpdateNoteInput from './dto/updateNoteInput';
import UpdateNoteOutput from './dto/updateNoteOutput';
import http from '../httpService';

class NoteService {
  public async create(createNoteInput: CreateNoteInput): Promise<CreateNoteOutput> {
    let result = await http.post('api/services/app/Note/Create', createNoteInput);
    return result.data.result;
  }

  public async delete(entityDto: EntityDto) {
    let result = await http.delete('api/services/app/Note/Delete', { params: entityDto });
    return result.data;
  }

  public async get(entityDto: EntityDto): Promise<GetNoteOutput> {
    let result = await http.get('api/services/app/Note/Get', { params: entityDto });
    return result.data.result;
  }

  public async getAll(pagedFilterAndSortedRequest: PagedNoteResultRequestDto): Promise<PagedResultDto<GetAllNoteOutput>> {
    let result = await http.get('api/services/app/Note/GetAll', { params: pagedFilterAndSortedRequest });
    return result.data.result;
  }

  public async update(updateNoteInput: UpdateNoteInput): Promise<UpdateNoteOutput> {
    let result = await http.put('api/services/app/Note/Update', updateNoteInput);
    return result.data.result;
  }
}

export default new NoteService();
