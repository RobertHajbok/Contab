import { PagedFilterAndSortedRequest } from '../../dto/pagedFilterAndSortedRequest';

export interface PagedNoteResultRequestDto extends PagedFilterAndSortedRequest  {
    keyword: string
}
