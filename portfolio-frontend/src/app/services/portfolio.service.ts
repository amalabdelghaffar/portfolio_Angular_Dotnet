import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';

export interface Profile {
  id: number; fullName: string; title: string; email: string;
  phone: string; location: string; about: string;
  githubUrl: string; linkedinUrl: string; avatarUrl: string;
}
export interface Experience {
  id: number; title: string; company: string; location: string;
  startDate: string; endDate: string; description: string;
  technologies: string; isCurrent: boolean; order: number;
}
export interface Education {
  id: number; degree: string; institution: string; location: string;
  startDate: string; endDate: string; description: string; order: number;
}
export interface Skill {
  id: number; name: string; category: string; level: number; icon: string;
}
export interface Certification {
  id: number; name: string; issuer: string; date: string; description: string;
}
export interface Language {
  id: number; name: string; level: number; proficiency: string;
}
export interface CommunityActivity {
  id: number; role: string; organization: string;
  startDate: string; endDate: string; order: number;
}

@Injectable({ providedIn: 'root' })
export class PortfolioService {
  private dataUrl = 'assets/data.json';

  constructor(private http: HttpClient) { }

  private getData(): Observable<any> {
    return this.http.get<any>(this.dataUrl);
  }

  getProfile(): Observable<Profile> {
    return this.getData().pipe(map(d => d.profile));
  }
  getExperiences(): Observable<Experience[]> {
    return this.getData().pipe(map(d => d.experiences));
  }
  getEducations(): Observable<Education[]> {
    return this.getData().pipe(map(d => d.educations));
  }
  getSkills(): Observable<Skill[]> {
    return this.getData().pipe(map(d => d.skills));
  }
  getCertifications(): Observable<Certification[]> {
    return this.getData().pipe(map(d => d.certifications));
  }
  getLanguages(): Observable<Language[]> {
    return this.getData().pipe(map(d => d.languages));
  }
  getCommunity(): Observable<CommunityActivity[]> {
    return this.getData().pipe(map(d => d.community));
  }
}
